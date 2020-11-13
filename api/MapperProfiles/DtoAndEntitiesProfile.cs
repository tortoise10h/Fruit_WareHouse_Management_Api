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
            CreateMap<ProductInGoodsReceivingNote, GoodsReceivingDetail>();
            CreateMap<GoodsReceivingDetail, ProductInGoodsReceivingNote>();
            CreateMap<AddProductToSupplierDTO, SupplierProduct>();
        }
    }
}
