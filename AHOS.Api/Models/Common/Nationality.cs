using System;
using System.Collections.Generic;

namespace AHOS.Api.Models.Common;

public partial class Nationality
{
    public Guid Id { get; set; }

    public Guid? Key { get; set; }

    public int? Code { get; set; }

    public string? CodeStr { get; set; }

    public string Name { get; set; } = null!;
}
