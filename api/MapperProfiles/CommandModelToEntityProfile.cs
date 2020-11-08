using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingDetail;
using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingNote;
using api.CQRS.ProductCategories.Commands.CreateProductCategory;
using api.CQRS.ProductCategories.Commands.UpdateProductCategory;
using api.CQRS.Products.Commands.CreateProducts;
using api.CQRS.Products.Commands.UpdateProducts;
using api.CQRS.ProductUnits.Commands.CreateProductUnits;
using api.CQRS.ProductUnits.Commands.UpdateProductUnits;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.UpdateProducts;
using api.CQRS.PurchaseProposalForms.Commands.UpdatePurchaseProposalDetails;
using api.Entities;
using AutoMapper;

namespace api.MapperProfiles
{
    public class CommandModelToEntityProfile : Profile
    {
        public CommandModelToEntityProfile()
        {
            /** Product Category*/
            CreateMap<CreateProductCategoryCommand, ProductCategory>();
            CreateMap<UpdateProductCategoryCommand, ProductCategory>();

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
            CreateMap<UpdatePurchaseProposalDetailCommand, PurchaseProposalDetail>();

            /** GoodsReceivingNote */
            CreateMap<CreateGoodsReceivingNoteCommand, GoodsReceivingNote>();

            /** GoodsReceivingDetail */
            CreateMap<CreateGoodsReceivingDetailCommand, GoodsReceivingDetail>();
        }
    }
}
