using AutoMapper;
using api.Contracts.V1.ResponseModels.User;
using api.Entities;

namespace api.MapperProfiles
{
    public class EntityToResponseProfile : Profile
    {
        public EntityToResponseProfile()
        {
            CreateMap<ApplicationUser, UserResponse>();
        }
    }
}