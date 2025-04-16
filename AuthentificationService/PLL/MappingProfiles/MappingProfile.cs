using AutoMapper;

namespace AuthentificationService.PLL.MappingProfiles
{
        public class MappingProfile : Profile
        {
            public MappingProfile()
            {

                CreateMap<User, UserViewModel>().ConstructUsing(v => new UserViewModel(v));
            }
        }
}
