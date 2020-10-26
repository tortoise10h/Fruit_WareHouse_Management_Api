using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using api.Common.Enums;
using api.Contracts.V1.RequestModels;
using api.Contracts.V1.ResponseModels;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text.RegularExpressions;
using api.Contracts.V1.Exceptions;

namespace api.Helpers
{
    public interface IPaginationHelpers
    {
        Task<PagedResponse<TResponse>> Paginate<TEntity, TResponse>(
            IQueryable<TEntity> queryable,
            PaginationQuery query);
    }

    public class PaginationHelpers : IPaginationHelpers
    {
        private readonly IMapper _mapper;

        public PaginationHelpers(IMapper mapper)
        {
            _mapper = mapper;
        }

        private PagedResponse<TResponse> CreatePaginatedResponse<TEntity, TResponse>(
            PaginationQuery query,
            List<TEntity> entities,
            int total)
        {
            int totalPage = (int)Math.Ceiling((double)total / query.Limit);

            return new PagedResponse<TResponse>
            {
                Data = _mapper.Map<IEnumerable<TResponse>>(entities),
                CurrentPage = query.Page,
                PageSize = query.Limit,
                TotalPages = totalPage == 0 ? 1 : totalPage,
                TotalItems = total
            };
        }
        public async Task<PagedResponse<TResponse>> Paginate<TEntity, TResponse>(
            IQueryable<TEntity> queryable,
            PaginationQuery query)
        {
            int skip = (query.Page - 1) * query.Limit;

            queryable = CustomSortQuery<TEntity>(queryable, query.SortName, query.IsAscending);
            queryable = CustomFilterQuery<TEntity>(queryable, query.Filters, query.FilterConditions);

            var entities = await queryable
                .Skip(skip)
                .Take(query.Limit)
                .ToListAsync();
            var totalEntities = await queryable.CountAsync();

            return CreatePaginatedResponse<TEntity, TResponse>(
                query, entities, totalEntities);
        }

        public IQueryable<TEntity> CustomSortQuery<TEntity>(
            IQueryable<TEntity> queryable,
            string sortName,
            bool isAscending
        )
        {
            var type = typeof(TEntity);
            var field = type.GetField(sortName);
            var parameter = Expression.Parameter(type, "p");
            PropertyInfo property = typeof(TEntity).GetProperty(sortName);
            if (property == null)
            {
                /** If field name is provided by client is not exist 
                 * then take the default field
                 */
                property = typeof(TEntity).GetProperty(PaginationDefault.SortName);
            }

            Expression propertyAccess = Expression.MakeMemberAccess(parameter, property);

            var orderByExp = Expression.Lambda(propertyAccess, parameter);
            MethodCallExpression resultExp = Expression.Call(
                typeof(Queryable),
                isAscending ? "OrderBy" : "OrderByDescending",
                new[] { type, property.PropertyType },
                queryable.Expression,
                Expression.Quote(orderByExp)
            );

            return queryable.Provider.CreateQuery<TEntity>(resultExp);
        }
        public IQueryable<TEntity> CustomFilterQuery<TEntity>(
            IQueryable<TEntity> queryable,
            Dictionary<string, string> filters,
            Dictionary<string, string> filterConditions
        )
        {
            if (filters != null && filters.Count > 0)
            {
                foreach (KeyValuePair<string, string> entry in filters)
                {
                    string filterOperator = "";
                    if (filterConditions != null && filterConditions.Count > 0)
                    {
                        filterConditions.TryGetValue(entry.Key, out filterOperator);
                    }

                    switch (filterOperator)
                    {
                        case "not":
                            {
                                queryable = queryable
                                    .Where($"{entry.Key} != {entry.Value}");
                                break;
                            }
                        case "like":
                            {
                                queryable = queryable
                                    .Where($"{entry.Key}.Contains({entry.Value})");
                                break;
                            }
                        case "=":
                            {
                                queryable = queryable
                                    .Where($"{entry.Key} = {entry.Value}");
                                break;
                            }
                        case ">":
                            {
                                queryable = queryable
                                    .Where($"{entry.Key} > {entry.Value}");
                                break;
                            }
                        case "<":
                            {
                                queryable = queryable
                                    .Where($"{entry.Key} < {entry.Value}");
                                break;
                            }
                        case ">=":
                            {
                                queryable = queryable
                                    .Where($"{entry.Key} >= {entry.Value}");
                                break;
                            }
                        case "<=":
                            {
                                queryable = queryable
                                    .Where($"{entry.Key} <= {entry.Value}");
                                break;
                            }
                        case "in":
                            {
                                string inRegex = @"^[^\,]+(\,[^\,]+)*$";
                                var match = Regex.Match(entry.Value, inRegex, RegexOptions.IgnoreCase);
                                if (!match.Success)
                                {
                                    throw new BadRequestException(new ApiError("The correct value when using in dynamic filter is 'value,value,value,value'"));
                                }

                                queryable = queryable
                                    .Where($"{entry.Key} IN ({entry.Value})");
                                break;
                            }
                        case "notin":
                            {
                                string inRegex = @"^[^\,]+(\,[^\,]+)*$";
                                var match = Regex.Match(entry.Value, inRegex, RegexOptions.IgnoreCase);
                                if (!match.Success)
                                {
                                    throw new BadRequestException(new ApiError("The correct value when using not in dynamic filter is 'value,value,value,value'"));
                                }

                                queryable = queryable
                                    .Where($"!({entry.Key} IN ({entry.Value}))");
                                break;
                            }
                        case "between":
                            {
                                string betweenRegex = @"^(\b[^\,]+\,[^\,]+\b)$";
                                var match = Regex.Match(entry.Value, betweenRegex, RegexOptions.IgnoreCase);
                                if (!match.Success)
                                {
                                    throw new BadRequestException(new ApiError("The correct value when using between dynamic filter is 'value,value'"));
                                }

                                var values = entry.Value.ToString().Split(",");
                                queryable = queryable
                                    .Where($"{entry.Key} >= {values[0]} && {entry.Key} <= {values[1]}");
                                break;
                            }
                        default:
                            {
                                queryable = queryable
                                    .Where($"{entry.Key} = {entry.Value}");
                                break;
                            }
                    }
                }
            }

            return queryable;
        }
    }
}
