using AHOS.Api.Models.Common;

namespace AHOS.Api.Dto.CitizenApplication.Base
{
    public partial class BaseCreateCitizenPatientDto
    {
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
