using System;
using System.Collections.Generic;
using AHOS.Api.Models.Base;
using AHOS.Api.Models.Common;
using AHOS.Api.Models.Patient.Base;

namespace AHOS.Api.Models.Patient;

public partial class NonCitizenApplicationService : BaseApplicationService
{
    public Guid NonCitizenApplicationId { get; set; }

    public virtual NonCitizenApplication NonCitizenApplication { get; set; } = null!;

}
