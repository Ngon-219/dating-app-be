using AutoMapper;
using DatingApp.Model;

namespace DatingApp.Dtos
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDto, AppUser>();
            CreateMap<AppUser, UserDto>();
        }
    }
}
