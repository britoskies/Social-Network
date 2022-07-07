using AutoMapper;
using SocialNetwork.Core.Application.ViewModels.Publications;
using SocialNetwork.Core.Application.ViewModels.User;
using SocialNetwork.Core.Domain.Entities;

namespace SocialNetwork.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<PublicationModel, PublicationViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastUpdate, opt => opt.Ignore())
                .ForMember(dest => dest.LastUpdateBy, opt => opt.Ignore());

            CreateMap<PublicationModel, SavePublicationViewModel>()
                .ForMember(dest => dest.File, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastUpdate, opt => opt.Ignore())
                .ForMember(dest => dest.LastUpdateBy, opt => opt.Ignore());


            CreateMap<UserModel, UserViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastUpdate, opt => opt.Ignore())
                .ForMember(dest => dest.LastUpdateBy, opt => opt.Ignore());

            CreateMap<UserModel, RegisterUserViewModel>()
                .ForMember(dest => dest.ConfirmPassword, opt => opt.Ignore())
                .ForMember(dest => dest.ErrorUserExists, opt => opt.Ignore())
                .ForMember(dest => dest.File, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastUpdate, opt => opt.Ignore())
                .ForMember(dest => dest.LastUpdateBy, opt => opt.Ignore());
        }
    }
}
