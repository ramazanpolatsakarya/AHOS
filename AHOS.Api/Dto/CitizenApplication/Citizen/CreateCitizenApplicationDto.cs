using System.Collections;
using AHOS.Api.Enums;
using AHOS.Api.Models.Base;
using AHOS.Api.Models.Patient;

namespace AHOS.Api.Dto.CitizenApplication.Citizen
{
    //Getat yada Rapor üzerinden almış olması önemli değil hepsini tek bir yapıda kullanabiliriz
    public class CreateCitizenApplicationDto
    {

        //public Guid PatientId { get; set; }
        //hasta bilgisini otomatik alacağız
        //public CreateCitizenPatientDto Patient { get; set; }

        //public ApplicationStatus ApplicationStatus { get; set; } = ApplicationStatus.Pedding;


        public List<CreateCitizenApplicationServiceDto> Services { get; set; }
    }


}
