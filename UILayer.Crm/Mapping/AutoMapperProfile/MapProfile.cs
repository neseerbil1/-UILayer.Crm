using AutoMapper;
using Crm.DTO.DTOs.AnnouncementDtos;
using Crm.DTO.DTOs.AppUserDtos;
using Crm.DTO.DTOs.ProductDtos;
using Crm.EntityLayer.Concrete;

namespace UILayer.Crm.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            //Announcement ve AnnouncementAddDto türleri arasında bir eşleme oluşturmayı amaçlar. Registiration
            CreateMap<Announcement, AnnouncementAddDto>();
            CreateMap<AnnouncementAddDto, Announcement>();

            CreateMap<Announcement, AnnouncementListDto>();
            CreateMap<AnnouncementListDto, Announcement>();

            CreateMap<Announcement, AnnouncementUpdateDto>();
            CreateMap<AnnouncementUpdateDto, Announcement>();

            CreateMap<AppUser, AppUserRegisterDto>();
            CreateMap<AppUserRegisterDto, AppUser>();

            CreateMap<Product, ProductAddDto>();
            CreateMap<ProductAddDto, Product > ();



        }
    }
}
