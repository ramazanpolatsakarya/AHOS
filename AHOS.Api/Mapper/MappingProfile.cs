using AHOS.Api.Dto.CitizenApplication.Citizen;
using AHOS.Api.Dto.CitizenApplication.NonCitizen;
using AHOS.Api.Models.Patient.Citizen;
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
