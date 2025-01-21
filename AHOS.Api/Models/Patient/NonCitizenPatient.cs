using System;
using System.Collections;
using System.Collections.Generic;
using AHOS.Api.Models.Base;
using AHOS.Api.Models.Common;

namespace AHOS.Api.Models.Patient;

public partial class NonCitizenPatient : BaseEntity
{
    public Guid Id { get; set; }

    public BitArray Active { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public Guid GenderId { get; set; }

    public DateOnly BirthDate { get; set; }

    public BitArray Deceased { get; set; } = null!;

    public string PassportNumber { get; set; } = null!;

    public BitArray? PassportNumberVerified { get; set; }

    public Guid NoncitizenPatientTypeId { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public Guid? NationalityId { get; set; }

    public virtual NoncitizenPatientType NoncitizenPatientType { get; set; } = null!;
}
