using AHOS.Api.Dto;
using AHOS.Api.Models.Patient;
using AutoMapper;

namespace AHOS.Api.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCitizenPatientDto, CitizenPatient>()
                    .ReverseMap();


            CreateMap<CreateCitizenApplicationServiceDto, CitizenApplicationService>()
            .ReverseMap();
        }
    }
}
