using api.CQRS.Products.Commands.CreateProducts;
using api.CQRS.Products.Commands.UpdateProducts;
using api.CQRS.ProductUnits.Commands.CreateProductUnits;
using api.CQRS.ProductUnits.Commands.UpdateProductUnits;
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
        }
    }
}
