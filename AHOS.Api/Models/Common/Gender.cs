﻿using System;
using System.Collections.Generic;
using AHOS.Api.Models.Base;
using AHOS.Api.Models.Patient;

namespace AHOS.Api.Models.Common;

public partial class Gender
{
    public Guid Id { get; set; }

    public Guid? Key { get; set; }

    public int? Code { get; set; }

    public string? CodeStr { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CitizenPatient> CitizenPatients { get; set; } = new List<CitizenPatient>();
}
