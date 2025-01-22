using AHOS.Api.Dto.CitizenApplication.Base;
using AHOS.Api.Models.Common;

namespace AHOS.Api.Dto.CitizenApplication.Citizen
{
    public partial class CreateCitizenPatientDto: BaseCreateCitizenPatientDto
    {
        public long IdentityNumber { get; set; }

    }


}
