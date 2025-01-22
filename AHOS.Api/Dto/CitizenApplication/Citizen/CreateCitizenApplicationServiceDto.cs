namespace AHOS.Api.Dto.CitizenApplication.Citizen
{
    public class CreateCitizenApplicationServiceDto
    {
        public Guid CitizenApplicationId { get; set; }

        public Guid ServiceId { get; set; }


        public Guid FamilyDoctorId { get; set; }


        public Guid? CityId { get; set; }

        //public double Price { get; set; }
        //public string ServiceReferanceCode { get; set; } = null!;

    }


}
