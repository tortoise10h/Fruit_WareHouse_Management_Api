using api.Contracts.V1.Dtos;
using api.CQRS.GoodsReceivingNotes.Commands.CreateGoodsReceivingDetail;
using api.CQRS.GoodsReceivingNotes.Commands.UpdateGoodsReceivingDetail;
using api.CQRS.Orders.Commands.CreateOrderDetails;
using api.CQRS.Orders.Commands.UpdateOrderDetails;
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

            CreateMap<CreateOrderDetailsCommand, ProductInOrder>();
            CreateMap<ProductInOrder, CreateOrderDetailsCommand>();

            CreateMap<UpdateOrderDetailsCommand, ProductInOrder>();
            CreateMap<ProductInOrder, UpdateOrderDetailsCommand>();
        }
    }
}