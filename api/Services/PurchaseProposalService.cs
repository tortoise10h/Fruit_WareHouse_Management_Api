using api.Contracts.V1.Exceptions;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.Entities;
using api.Helpers;
using AutoMapper;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace api.Services
{
    public interface IPurchaseProposalService
    {
        Task MakeValidProductListWhenCreatePurchaseProposalForm(List<CreatePurchaseProposalDetailCommand> purchaseProposalDetails);
    }

    public class PurchaseProposalService : IPurchaseProposalService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public PurchaseProposalService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task MakeValidProductListWhenCreatePurchaseProposalForm(List<CreatePurchaseProposalDetailCommand> purchaseProposalDetails)
        {
            /** Make sure all product id in list is uniqe */
            purchaseProposalDetails = purchaseProposalDetails
                .GroupBy(x => x.ProductId)
                .Select(x => x.First())
                .ToList();

            /** Make sure all products in list are existed */
            var productIds = purchaseProposalDetails
                .Select(x => x.ProductId)
                .ToList();

            var products = await _context.Products
                .Where(p => productIds.Contains(p.Id))
                .ToListAsync();

            if (productIds.Count() != products.Count())
            {
                throw new NotFoundException();
            }

            /** Validate max quantity of product */
            string maxQuantityErrorResponse = "";
            foreach (var p in products)
            {
                var requestProduct = purchaseProposalDetails
                    .SingleOrDefault(rp => rp.ProductId == p.Id);

                if (p.MaxQuantity != null)
                {
                    int totalQuantityAfterImport = requestProduct.Quantity + p.Quantity;
                    if (totalQuantityAfterImport > p.MaxQuantity)
                    {
                        maxQuantityErrorResponse += $"Số lượng sau khi nhập vào của sản phẩm '{p.Name}' [{totalQuantityAfterImport}] lớn số lượng tối đa cho phép của sản phẩm [{p.MaxQuantity}]<br/>";
                    }
                }
            }

            if (maxQuantityErrorResponse.Equals("") == false)
            {
                throw new BadRequestException(
                    new ApiError(maxQuantityErrorResponse)
                    );
            }
        }
    }
}
