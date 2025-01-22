using System;
using System.Collections.Generic;
using AHOS.Api.Models.Patient.Citizen;

namespace AHOS.Api.Models.Common;

public partial class Service
{
    public Guid Id { get; set; }

    public int? Code { get; set; }

    public string Name { get; set; } = null!;

    public double? Price { get; set; }

}
