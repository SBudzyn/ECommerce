using AutoMapper;

namespace ECommerce.Models
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductFullResponse>()
                .ForMember(dest => dest.ManufacturerName, opt =>
                {
                    opt.PreCondition(src => src.Manufacturer != null);
                    opt.MapFrom(src => src.Manufacturer!.Name);
                })
                .ForMember(dest => dest.Photos, opt => opt.MapFrom(src => new List<string>(src.Photos.Split(';', StringSplitOptions.RemoveEmptyEntries))))
                .ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews  ))
                .ForMember(dest => dest.SeriaName, opt =>
                {
                    opt.PreCondition(src => src.Seria != null);
                    opt.MapFrom(src => src.Seria!.Name);
                });

            CreateMap<Product, ProductShortResponse>().ForMember(dest => dest.Photo, opt => opt.MapFrom(src => src.Photos.Split(';', StringSplitOptions.RemoveEmptyEntries)[0]));

            CreateMap<Review, ReviewResponse>();
        }
    }
}
