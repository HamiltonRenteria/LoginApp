using Application.DTOs.User;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappers
{
    public class UserMappingsProfile : Profile
    {
        public UserMappingsProfile()
        {
            CreateMap<UserRequestDto, User>();
            CreateMap<TokenRequestDto, User>();
        }
    }
}
