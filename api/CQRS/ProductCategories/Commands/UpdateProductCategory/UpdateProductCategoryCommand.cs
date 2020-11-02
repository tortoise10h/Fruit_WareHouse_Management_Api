using System;
using api.Contracts.V1.ResponseModels.ProductCategories;
using MediatR;

namespace api.CQRS.ProductCategories.Commands.UpdateProductCategory
{
    public class UpdateProductCategoryCommand : IRequest<ProductCategoryResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
