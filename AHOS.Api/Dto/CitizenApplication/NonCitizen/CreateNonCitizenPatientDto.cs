using AHOS.Api.Dto.CitizenApplication.Base;
using AHOS.Api.Models.Common;

namespace AHOS.Api.Dto.CitizenApplication.NonCitizen
{

    public partial class CreateNonCitizenPatientDto : BaseCreateCitizenPatientDto
    {
        public string Nationality { get; set; } = null!; //Uyruk

        public string PassportNumber { get; set; } = null!;

        public bool? PassportNumberVerified { get; set; }

        public Guid NoncitizenPatientTypeId { get; set; }


        public Guid? NationalityId { get; set; }

        public virtual NonCitizenPatientType NonCitizenPatientType { get; set; } = null!;


    }


}
