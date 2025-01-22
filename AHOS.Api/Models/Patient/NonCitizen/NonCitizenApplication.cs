using System;
using System.Collections.Generic;
using AHOS.Api.Enums;
using AHOS.Api.Models.Base;

namespace AHOS.Api.Models.Patient;

public partial class NonCitizenApplication : BaseEntity
{

    public Guid PatientId { get; set; }

    public ApplicationStatus ApplicationStatus { get; set; } = ApplicationStatus.Pedding;

    public virtual ICollection<NonCitizenApplicationService> NonCitizenApplicationServices { get; set; } = [];
}
