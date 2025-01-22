using System.Collections;
using AHOS.Api.Enums;
using AHOS.Api.Models.Base;
using AHOS.Api.Models.Patient;

namespace AHOS.Api.Dto.CitizenApplication.NonCitizen
{
    //Getat yada Rapor üzerinden almış olması önemli değil hepsini tek bir yapıda kullanabiliriz
    public class CreateNonCitizenApplicationDto
    {

        //public Guid PatientId { get; set; }
        //hasta bilgisini otomatik alacağız
        //public CreateCitizenPatientDto Patient { get; set; }

        //public ApplicationStatus ApplicationStatus { get; set; } = ApplicationStatus.Pedding;


        public List<CreateNonCitizenApplicationServiceDto> Services { get; set; }
    }


}
