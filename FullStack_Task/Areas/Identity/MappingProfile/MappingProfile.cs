using AutoMapper;
using FullStack_Task.Areas.Identity.Models;
using FullStack_Task.Areas.Identity.Models.ViewModels;

namespace FullStack_Task.Areas.Identity.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, ContactValidViewModel>();
            CreateMap<ContactValidViewModel, ApplicationUser>();

            CreateMap<ApplicationUser, AreasValidViewModel>();
            CreateMap<AreasValidViewModel, ApplicationUser>();

            CreateMap<ApplicationUser, PasswordValidViewModel> ();
            CreateMap<PasswordValidViewModel, ApplicationUser>();
        }
    }
}
