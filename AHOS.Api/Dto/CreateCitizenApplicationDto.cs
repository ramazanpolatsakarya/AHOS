using AHOS.Api.Enums;
using AHOS.Api.Models.Patient;

namespace AHOS.Api.Dto
{
    //Getat yada Rapor üzerinden almış olması önemli değil hepsini tek bir yapıda kullanabiliriz
    public class CreateCitizenReportApplicationDto
    {
        public Guid PatientId { get; set; }


        public ApplicationStatus ApplicationStatus { get; set; }


        public List<CreateCitizenApplicationServiceDto> Services { get; set; }
    }

    public class CreateCitizenApplicationServiceDto
    {
        public Guid CitizenApplicationId { get; set; }

        public Guid ServiceId { get; set; }


        // her servis için farklı bir aile hekimi seçebilir.
        public Guid FamilyDoctorId { get; set; }

        public double Price { get; set; }

        // aile hekimi üzerinden şehri tekrar sorgulamayalım.. burdan filtreleyelim. ilerde de kullanılacaktır.
        public Guid? CityId { get; set; }

        // Bankaya göndereceğimiz referans kodu
        public string ServiceReferanceCode { get; set; } = null!;

    }



}
