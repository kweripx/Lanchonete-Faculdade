using AutoMapper;
using VendasLanches03.Models;

namespace VendasLanches03.DTO.Mapping;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<Categoria, CategoryDTO>().ReverseMap();
        CreateMap<Pedido, OrderDTO>().ReverseMap();
    }
}
