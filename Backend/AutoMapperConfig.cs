using AutoMapper;

using Backend.Models;
using Domain;

public class AutoMapperConfig : Profile
{
    public AutoMapperConfig()
    {
        CreateMap<Vehicle, VehicleDto>()
            .ForMember(d => d.DateAdded, opt => opt.MapFrom(source => source.DateAdded.ToString("yyyy-MM-dd")));
        CreateMap<Location, LocationDto>();
        CreateMap<Warehouse, CarsDto>()
            .ForMember(d => d.Location, opt => opt.MapFrom(source => source.LocationName))
            .ForMember(d => d.Vehicles, opt => opt.MapFrom(source => source.Vehicles));
        CreateMap<Warehouse, WarehouseDto>()
            .ForMember(d => d.Location, opt => opt.MapFrom(source => source.Location))
            .ForMember(d => d.Cars, opt => opt.MapFrom(source => source));
    }
}
