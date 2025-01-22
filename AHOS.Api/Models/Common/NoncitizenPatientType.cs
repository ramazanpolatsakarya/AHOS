using System;
using System.Collections.Generic;
using AHOS.Api.Models.Patient.NonCitizen;

namespace AHOS.Api.Models.Common;

public partial class NonCitizenPatientType
{
    public Guid Id { get; set; }

    public Guid? Key { get; set; }

    public int? Code { get; set; }

    public string? CodeStr { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<NonCitizenPatient> NonCitizenPatients { get; set; } = new List<NonCitizenPatient>();
}
