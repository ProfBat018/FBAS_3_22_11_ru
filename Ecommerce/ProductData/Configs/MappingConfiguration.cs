using AutoMapper;
using ProductData.DTO;
using ProductData.Models;

namespace ProductData.Configs;

public class MappingConfiguration
{
    public static Mapper InitializeConfig()
    {
        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Product, ProductViewModel>()
                .ForMember(dest => dest.Name,
                    x => x.MapFrom(p => p.Name))
                .ForMember(dest => dest.Description,
                    x => x.MapFrom(p => p.Description))
                .ForMember(dest => dest.Price,
                    x => x.MapFrom(p => p.Price));


            cfg.CreateMap<PaginatedList<Product>, PaginatedProductViewModel>()
                .ForMember(dest => dest.items,
                    x => x.MapFrom(p => p.Items))
                .ForMember(dest => dest.pageNumber,
                    x => x.MapFrom(p => p.PageNumber))
                .ForMember(dest => dest.pageSize,
                    x => x.MapFrom(p => p.PageSize))
                .ForMember(dest => dest.hasNext,
                    x => x.MapFrom(p => p.HasNextPage))
                .ForMember(dest => dest.hasPrevious,
                    x => x.MapFrom(p => p.HasPreviousPage))
                .ForMember(dest => dest.totalCount,
                    x => x.MapFrom(p => p.TotalCount))
                .ForMember(dest => dest.totalPages,
                    x => x.MapFrom(p => p.TotalPages));
            
            



        });

        var mapper = new Mapper(mapperConfig);

        return mapper;
    }
}