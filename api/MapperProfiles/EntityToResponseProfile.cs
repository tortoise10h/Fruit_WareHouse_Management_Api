using AutoMapper;
using api.Contracts.V1.ResponseModels.User;
using api.Entities;
using api.Contracts.V1.ResponseModels.Products;
using api.Contracts.V1.ResponseModels.ProductCategories;
using api.Contracts.V1.ResponseModels.ProductUnits;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;

namespace api.MapperProfiles
{
    public class EntityToResponseProfile : Profile
    {
        public EntityToResponseProfile()
        {
            CreateMap<ApplicationUser, UserResponse>();

            CreateMap<ProductCategory, ProductCategoryResponse>();

            CreateMap<Product, ProductResponse>();

            CreateMap<ProductUnit, ProductUnitResponse>();

            CreateMap<PurchaseProposalForm, PurchaseProposalFormResponse>();

            CreateMap<PurchaseProposalDetail, PurchaseProposalDetailResponse>();
        }
    }
}