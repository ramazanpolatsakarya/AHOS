using System;
using System.Collections.Generic;
using AHOS.Api.Models.Base;
using AHOS.Api.Models.Common;
using AHOS.Api.Models.Patient.Base;

namespace AHOS.Api.Models.Patient.Citizen;

public partial class CitizenApplicationService : BaseApplicationService
{
    public Guid CitizenApplicationId { get; set; }

    public virtual CitizenApplication CitizenApplication { get; set; } = null!;

}
