using api.Contracts.V1.Dtos;
using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingDetail;
using api.Entities;
using AutoMapper;

namespace api.MapperProfiles
{
    public class DtoAndEntitiesProfile : Profile
    {
        public DtoAndEntitiesProfile()
        {
            /** ProductInGoodsReceivingNote - GoodsReceivingDetail */
            CreateMap<ProductInGoodsReceivingNote, GoodsReceivingDetail>();
            CreateMap<GoodsReceivingDetail, ProductInGoodsReceivingNote>();

            /** ProductInOrder - OrderDetail */
            CreateMap<ProductInOrder, OrderDetail>();
            CreateMap<OrderDetail, ProductInOrder>();
            CreateMap<AddProductToSupplierDTO, SupplierProduct>();
        }
    }
}
