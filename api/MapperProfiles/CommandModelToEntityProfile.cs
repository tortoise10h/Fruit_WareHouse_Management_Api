using api.CQRS.Products.Commands.CreateProducts;
using api.CQRS.Products.Commands.UpdateProducts;
using api.CQRS.ProductUnits.Commands.CreateProductUnits;
using api.CQRS.ProductUnits.Commands.UpdateProductUnits;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.UpdateProducts;
using api.Entities;
using AutoMapper;

namespace api.MapperProfiles
{
    public class CommandModelToEntityProfile : Profile
    {
        public CommandModelToEntityProfile()
        {
            /** Product */
            CreateMap<CreateProductCommand, Product>();
            CreateMap<UpdateProductCommand, Product>();

            /** ProductUnit */
            CreateMap<CreateProductUnitCommand, ProductUnit>();
            CreateMap<UpdateProductUnitCommand, ProductUnit>();

            /** PurchaseProposalForm */
            CreateMap<CreatePurchaseProposalFormCommand, PurchaseProposalForm>();
            CreateMap<UpdatePurchaseProposalFormCommand, PurchaseProposalForm>();

            /** PurchaseProposalDetail */
            CreateMap<CreatePurchaseProposalDetailCommand, PurchaseProposalDetail>();
        }
    }
}
