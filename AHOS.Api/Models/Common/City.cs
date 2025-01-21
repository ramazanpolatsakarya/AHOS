using System;
using System.Collections.Generic;
using AHOS.Api.Models.Base;

namespace AHOS.Api.Models.Common;

public partial class City 
{
    public Guid Id { get; set; }

    public int? Code { get; set; }

    public string Name { get; set; } = null!;
}
