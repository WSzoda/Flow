using AutoMapper;
using Flow.Core.DTOs.Response;
using Flow.Core.Entities;

namespace Flow;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Shop, ShopDto>();
    }
}