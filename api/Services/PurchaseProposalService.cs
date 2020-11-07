using api.Contracts.V1.Exceptions;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.UpdatePurchaseProposalDetails;
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
        Task<List<CreatePurchaseProposalDetailCommand>> ValidateAdddedProducts(List<CreatePurchaseProposalDetailCommand> purchaseProposalDetails);
        Task ValidateUniqueProductsInPurchaseProposalForm(List<CreatePurchaseProposalDetailCommand> purchaseProposalDetails, int purchaseProposalFormId);
        Task<List<UpdatePurchaseProposalDetailCommand>> MakeSureListPurchaseProposalDetailUpdateValid(List<UpdatePurchaseProposalDetailCommand> purchaseProposalDetails, int purchaseProposalFormId);
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

        public async Task<List<CreatePurchaseProposalDetailCommand>> ValidateAdddedProducts(List<CreatePurchaseProposalDetailCommand> purchaseProposalDetails)
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
                    double totalQuantityAfterImport = requestProduct.Quantity + p.Quantity;
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

            return purchaseProposalDetails;
        }

        public async Task ValidateUniqueProductsInPurchaseProposalForm(List<CreatePurchaseProposalDetailCommand> purchaseProposalDetails, int purchaseProposalFormId)
        {
            var newProductIds = purchaseProposalDetails
                .Select(x => x.ProductId);

            var existedPurchaseProposalDetails = await _context.PurchaseProposalDetails
                .Where(x => x.PurchaseProposalFormId == purchaseProposalFormId &&
                    newProductIds.Contains(x.ProductId))
                .ToListAsync();

            if (existedPurchaseProposalDetails != null &&
                existedPurchaseProposalDetails.Count() > 0)
            {
                string errResponse = "";
                foreach(var eppd in existedPurchaseProposalDetails)
                {
                    errResponse += $"Sản phẩm với id {eppd.ProductId} đã tồn tại trong phiếu đề nghị<br/>";
                }

                throw new BadRequestException(new ApiError(errResponse));
            }
        }

        public async Task<List<UpdatePurchaseProposalDetailCommand>> MakeSureListPurchaseProposalDetailUpdateValid(List<UpdatePurchaseProposalDetailCommand> purchaseProposalDetails, int purchaseProposalFormId)
        {
            /** Make sure all product id in list is uniqe */
            purchaseProposalDetails = purchaseProposalDetails
                .GroupBy(x => x.Id)
                .Select(x => x.First())
                .ToList();

            /** Make sure all purchase proposal details exist in list are existed */
            var purchaseProposalDetailIds = purchaseProposalDetails
                .Select(x => x.Id)
                .ToList();

            var existedPurchaseProposalDetails = await _context.PurchaseProposalDetails
                .AsNoTracking()
                .Where(ppd => ppd.PurchaseProposalFormId == purchaseProposalFormId &&
                    purchaseProposalDetailIds.Contains(ppd.Id))
                .Include(ppd => ppd.Product)
                .ToListAsync();

            if (purchaseProposalDetailIds.Count() != existedPurchaseProposalDetails.Count())
            {
                throw new NotFoundException();
            }

            /** Validate max quantity of product */
            string maxQuantityErrorResponse = "";
            foreach (var ppd in purchaseProposalDetails)
            {
                var existedPurchaseProposalDetail = existedPurchaseProposalDetails
                    .SingleOrDefault(eppd => eppd.Id == ppd.Id);

                if (existedPurchaseProposalDetail.Product.MaxQuantity != null)
                {
                    double totalQuantityAfterUpdate = ppd.Quantity + existedPurchaseProposalDetail.Product.Quantity;
                    if (totalQuantityAfterUpdate > existedPurchaseProposalDetail.Product.MaxQuantity)
                    {
                        maxQuantityErrorResponse += $"Số lượng sau khi chỉnh sửa của sản phẩm '{existedPurchaseProposalDetail.Product.Name}' [{totalQuantityAfterUpdate}] lớn số lượng tối đa cho phép của sản phẩm [{existedPurchaseProposalDetail.Product.MaxQuantity}]<br/>";
                    }
                }
            }

            if (maxQuantityErrorResponse.Equals("") == false)
            {
                throw new BadRequestException(
                    new ApiError(maxQuantityErrorResponse)
                    );
            }

            return purchaseProposalDetails;
        }
    }
}
