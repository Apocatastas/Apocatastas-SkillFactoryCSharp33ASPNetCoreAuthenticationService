using AutoMapper;
using AuthentificationService.Models;

namespace AuthentificationService
{
        public class MappingProfile : Profile
        {
            public MappingProfile()
            {

                CreateMap<User, UserViewModel>().ConstructUsing(v => new UserViewModel(v));
            }
        }
}
