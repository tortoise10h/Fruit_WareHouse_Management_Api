using AutoMapper;
using api.Contracts.V1.ResponseModels.User;
using api.Entities;
using api.Contracts.V1.ResponseModels.Products;
using api.Contracts.V1.ResponseModels.ProductCategories;
using api.Contracts.V1.ResponseModels.ProductUnits;
using api.Contracts.V1.ResponseModels.PurchaseProposalForms;
using api.Contracts.V1.ResponseModels.GoodsReceivingNotes;
using api.Contracts.V1.ResponseModels.Orders;
using api.Contracts.V1.ResponseModels.Suppliers;
using api.Contracts.V1.ResponseModels.InventoryRecordForms;
using api.Contracts.V1.ResponseModels.GoodsDeliveryNotes;
using api.Contracts.V1.ResponseModels.ProductRemoveForms;
using api.Contracts.V1.ResponseModels.MerchandiseReturnProposals;
using api.Contracts.V1.ResponseModels.GoodsReceivingReturn;

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

            CreateMap<GoodsReceivingNote, GoodsReceivingNoteResponse>();

            CreateMap<GoodsReceivingDetail, GoodsReceivingDetailResponse>();

            CreateMap<Order, OrderResponse>();

            CreateMap<OrderDetail, OrderDetailResponse>();

            CreateMap<Supplier, SupplierResponse>();

            CreateMap<Supplier, SupplierResponse>();

            CreateMap<SupplierProduct, SupplierProductResponse>();

            CreateMap<InventoryRecordForm, InventoryRecordFormResponse>();

            CreateMap<InventoryRecordDetail, InventoryRecordDetailResponse>();

            CreateMap<GoodsDeliveryNote, GoodsDeliveryNoteResponse>();

            CreateMap<GoodsDeliveryDetail, GoodsDeliveryDetailResponse>();

            CreateMap<ProductRemoveForm, ProductRemoveFormResponse>();

            CreateMap<ProductRemoveDetail, ProductRemoveDetailResponse>();

            CreateMap<MerchandiseReturnProposal, MerchandiseReturnProposalResponse>();

            CreateMap<MerchandiseReturnDetail, MerchandiseReturnDetailResponse>();

            CreateMap<GoodsReceivingOfReturn, GoodsReceivingOfReturnResponse>();

            CreateMap<GoodsReceivingOfReturnDetail, GoodsReceivingOfReturnDetailResponse>();
        }
    }
}