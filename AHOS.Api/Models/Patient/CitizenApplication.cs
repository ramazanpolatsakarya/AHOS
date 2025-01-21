using System;
using System.Collections.Generic;
using AHOS.Api.Enums;
using AHOS.Api.Models.Base;

namespace AHOS.Api.Models.Patient;

public partial class CitizenApplication : BaseEntity
{
    public Guid Id { get; set; }

    public Guid PatientId { get; set; }

    public ApplicationStatus ApplicationStatus { get; set; }

    public virtual ICollection<CitizenApplicationService> CitizenApplicationServices { get; set; } = new List<CitizenApplicationService>();
}
