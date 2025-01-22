using System.Collections;
using AHOS.Api.Enums;
using AHOS.Api.Models.Base;
using AHOS.Api.Models.Common;
using AHOS.Api.Models.Patient;

namespace AHOS.Api.Dto
{
    //Getat yada Rapor üzerinden almış olması önemli değil hepsini tek bir yapıda kullanabiliriz
    public class CreateCitizenApplicationDto
    {

        //public Guid PatientId { get; set; }
        public CreateCitizenApplicationDto()
        {
            this.ApplicationStatus = ApplicationStatus.Pedding;
        }
        //hasta bilgisini otomatik alacağız
        //public CreateCitizenPatientDto Patient { get; set; }

        public ApplicationStatus ApplicationStatus { get; set; }


        public List<CreateCitizenApplicationServiceDto> Services { get; set; }
    }

    public class CreateCitizenApplicationServiceDto
    {
        public Guid CitizenApplicationId { get; set; }

        public Guid ServiceId { get; set; }


        public Guid FamilyDoctorId { get; set; }


        public Guid? CityId { get; set; }

        //public double Price { get; set; }
        //public string ServiceReferanceCode { get; set; } = null!;

    }

    public partial class CreateCitizenPatientDto
    {
        public long IdentityNumber { get; set; }

        public bool Active { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public Guid GenderId { get; set; }

        public DateOnly BirthDate { get; set; }

        public string BirthPlace { get; set; } = null!;


        public string PhoneNumber { get; set; } = null!;

        public virtual Gender Gender { get; set; } = null!;
    }


}
