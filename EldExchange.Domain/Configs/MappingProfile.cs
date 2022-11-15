using AutoMapper;
using EldExchange.Domain.Models.DALs;
using EldExchange.Domain.Models.DTOs;

namespace EldExchange.Domain.Config;

public static partial class MappingProfileExtensions
{
    private class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddAgencyDTO, Agency>()
                .ForCtorParam(nameof(Agency.Name), opt => opt.MapFrom(src => src.Name))
                .ForCtorParam(nameof(Agency.CNPJ), opt => opt.MapFrom(src => src.CNPJ))
                .ReverseMap()
                .ForCtorParam(nameof(AgencyDTO.Name), opt => opt.MapFrom(src => src.Name))
                .ForCtorParam(nameof(AgencyDTO.CNPJ), opt => opt.MapFrom(src => src.CNPJ));
            CreateMap<AgencyDTO, Agency>().ReverseMap();

            CreateMap<AddAddressDTO, Address>()
                .ForCtorParam(nameof(Address.ZipCode), opt => opt.MapFrom(src => src.ZipCode))
                .ForCtorParam(nameof(Address.Number), opt => opt.MapFrom(src => src.Number))
                .ForCtorParam(nameof(Address.StreetName), opt => opt.MapFrom(src => src.StreetName))
                .ReverseMap()
                .ForCtorParam(nameof(AddressDTO.ZipCode), opt => opt.MapFrom(src => src.ZipCode))
                .ForCtorParam(nameof(AddressDTO.Number), opt => opt.MapFrom(src => src.Number))
                .ForCtorParam(nameof(AddressDTO.StreetName), opt => opt.MapFrom(src => src.StreetName));
            CreateMap<AddressDTO, Address>().ReverseMap();


        }
    }
}


public static partial class MappingProfileExtensions
{
    private static IMapper? _mapper;
    private static IMapper Mapper
    {
        get
        {
            if (_mapper != null) return _mapper;
            _mapper = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            }).CreateMapper();

            return _mapper;
        }
    }

    public static TOut ToMapper<TOut>(this object obj) => Mapper.Map<TOut>(obj);

    public static async Task<Tout> ToMapperAsync<Tout>(this Task<object> obj) => Mapper.Map<Tout>(await obj);
}