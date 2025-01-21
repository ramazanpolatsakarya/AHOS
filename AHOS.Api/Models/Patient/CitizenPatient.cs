using System;
using System.Collections;
using System.Collections.Generic;
using AHOS.Api.Models.Base;
using AHOS.Api.Models.Common;

namespace AHOS.Api.Models.Patient;

public partial class CitizenPatient : BaseEntity
{
    public Guid Id { get; set; }

    public long IdentityNumber { get; set; }

    public BitArray Active { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public Guid GenderId { get; set; }

    public DateOnly BirthDate { get; set; }

    public string BirthPlace { get; set; } = null!;

    public BitArray Deceased { get; set; } = null!;

    public string MotherName { get; set; } = null!;

    public string FatherName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public virtual Gender Gender { get; set; } = null!;
}
