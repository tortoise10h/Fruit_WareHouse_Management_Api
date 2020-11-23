using api.CQRS.GoodsDeliveryNotes.Commands.CreateGoodsDeliveryDetails;
using api.CQRS.GoodsDeliveryNotes.Commands.CreateGoodsDeliveryNotes;
using api.CQRS.GoodsDeliveryNotes.Commands.UpdateGoodsDeliveryNotes;
using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingDetail;
using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingNote;
using api.CQRS.GoodsReceivingNotes.Commands.UpdateGoodsReceivingDetail;
using api.CQRS.GoodsReceivingNotes.Commands.UpdateGoodsReceivingNote;
using api.CQRS.GoodsReceivingReturn.Commands.CreateGoodsReceivingOfReturn;
using api.CQRS.GoodsReceivingReturn.Commands.UpdateGoodsReceivingOfReturn;
using api.CQRS.InventoryRecordForms.Commands.CreateInventoryDetail;
using api.CQRS.InventoryRecordForms.Commands.CreateInventoryForms;
using api.CQRS.InventoryRecordForms.Commands.UpdateInventoryDetail;
using api.CQRS.InventoryRecordForms.Commands.UpdateInventoryForms;
using api.CQRS.MerchandiseReturnProposals.Commands.CreateMerchandiseReturnDetail;
using api.CQRS.MerchandiseReturnProposals.Commands.CreateMerchandiseReturnProposal;
using api.CQRS.MerchandiseReturnProposals.Commands.UpdateMerchandiseReturnDetail;
using api.CQRS.MerchandiseReturnProposals.Commands.UpdateMerchandiseReturnProposal;
using api.CQRS.Orders.Commands.CreateOrderDetails;
using api.CQRS.Orders.Commands.CreateOrders;
using api.CQRS.Orders.Commands.UpdateOrderDetails;
using api.CQRS.Orders.Commands.UpdateOrders;
using api.CQRS.ProductCategories.Commands.CreateProductCategory;
using api.CQRS.ProductCategories.Commands.UpdateProductCategory;
using api.CQRS.ProductRemoveForms.Commands.CreateProductRemoveDetail;
using api.CQRS.ProductRemoveForms.Commands.CreateProductRemoveForm;
using api.CQRS.ProductRemoveForms.Commands.UpdateProductRemoveDetail;
using api.CQRS.ProductRemoveForms.Commands.UpdateProductRemoveForm;
using api.CQRS.Products.Commands.CreateProducts;
using api.CQRS.Products.Commands.UpdateProducts;
using api.CQRS.ProductUnits.Commands.CreateProductUnits;
using api.CQRS.ProductUnits.Commands.UpdateProductUnits;
using api.CQRS.PurchaseProposalForms.Commands.CreatePurchaseProposalForms;
using api.CQRS.PurchaseProposalForms.Commands.UpdateProducts;
using api.CQRS.PurchaseProposalForms.Commands.UpdatePurchaseProposalDetails;
using api.CQRS.Suppliers.Commands.CreateSupplier;
using api.CQRS.Suppliers.Commands.UpdateSupplier;
using api.CQRS.Users.Commands.CreateUsers;
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
            CreateMap<UpdateGoodsReceivingNoteCommand, GoodsReceivingNote>();

            /** GoodsReceivingDetail */
            CreateMap<CreateGoodsReceivingDetailCommand, GoodsReceivingDetail>();
            CreateMap<UpdateGoodsReceivingDetailCommand, GoodsReceivingDetail>();

            /** Order */
            CreateMap<CreateOrdersCommand, Order>();
            CreateMap<UpdateOrdersCommand, Order>();

            /** OrderDetail */
            CreateMap<CreateOrderDetailsCommand, OrderDetail>();
            CreateMap<UpdateOrderDetailsCommand, OrderDetail>();

            /** Supplier */
            CreateMap<CreateSupplierCommand, Supplier>();
            CreateMap<UpdateSupplierCommand, Supplier>();

            //** InventoryRecordForm */
            CreateMap<CreateInventoryFormCommand, InventoryRecordForm>();
            CreateMap<UpdateInventoryFormCommand, InventoryRecordForm>();

            //** InventoryRecordDetail */
            CreateMap<CreateInventoryDetailCommand, InventoryRecordDetail>();
            CreateMap<UpdateInventoryDetailCommand, InventoryRecordDetail>();

            /** GoodsDeliveryNote */
            CreateMap<CreateGoodsDeliveryNotesCommand, GoodsDeliveryNote>();
            CreateMap<UpdateGoodsDeliveryNotesCommand, GoodsDeliveryNote>();

            /** GoodsDeliveryDetail */
            CreateMap<CreateGoodsDeliveryDetailsCommand, GoodsDeliveryDetail>();
            //CreateMap<UpdateGoodsDeliveryDetailsCommand, GoodsDeliveryDetail>();

            //** ProductRemoveForm */
            CreateMap<CreateProductRemoveFormCommand, ProductRemoveForm>();
            CreateMap<UpdateProductRemoveFormCommand, ProductRemoveForm>();

            //** ProductRemoveDetail */
            CreateMap<CreateProductRemoveDetailCommand, ProductRemoveDetail>();
            CreateMap<UpdateProductRemoveDetailCommand, ProductRemoveDetail>();

            //** User */
            CreateMap<CreateUserCommand, ApplicationUser>();

            /** MerchandiseReturnProposal */
            CreateMap<CreateMerchandiseReturnProposalCommand, MerchandiseReturnProposal>();
            CreateMap<UpdateMerchandiseReturnProposalCommand, MerchandiseReturnProposal>();

            /** MerchandiseReturnDetail */
            CreateMap<CreateMerchandiseReturnDetailCommand, MerchandiseReturnDetail>();
            CreateMap<UpdateMerchandiseReturnDetailCommand, MerchandiseReturnDetail>();

            //** GoodsReceivingOfReturn */
            CreateMap<CreateGoodsReceivingOfReturnCommand, GoodsReceivingOfReturn>();
            CreateMap<UpdateGoodsReceivingOfReturnCommand, GoodsReceivingOfReturn>();
        }
    }
}
