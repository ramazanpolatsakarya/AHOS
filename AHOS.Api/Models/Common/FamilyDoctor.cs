using System;
using System.Collections.Generic;
using AHOS.Api.Models.Base;

namespace AHOS.Api.Models.Common;

public partial class FamilyDoctor
{
    public Guid Id { get; set; }

    public string? LastName { get; set; }

    public string? SurName { get; set; }
}
