using api.Contracts.V1.Dtos;
using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingDetail;
using api.CQRS.GoodsReceivingNotes.Commands.UpdateGoodsReceivingDetail;
using AutoMapper;

namespace api.MapperProfiles
{
    public class CommandAndDtoProfile : Profile
    {
        public CommandAndDtoProfile()
        {
            CreateMap<CreateGoodsReceivingDetailCommand, ProductInGoodsReceivingNote>();
            CreateMap<ProductInGoodsReceivingNote, CreateGoodsReceivingDetailCommand>();

            CreateMap<UpdateGoodsReceivingDetailCommand, ProductInGoodsReceivingNote>();
            CreateMap<ProductInGoodsReceivingNote, UpdateGoodsReceivingDetailCommand>();
        }
    }
}