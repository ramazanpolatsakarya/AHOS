using System;
using System.Collections;
using System.Collections.Generic;
using AHOS.Api.Models.Base;
using AHOS.Api.Models.Common;
using AHOS.Api.Models.Patient.Base;

namespace AHOS.Api.Models.Patient.NonCitizen;

public partial class NonCitizenPatient : BasePatient
{
    public string Nationality { get; set; } = null!; //Uyruk

    public string PassportNumber { get; set; } = null!;

    public BitArray PassportNumberVerified { get; set; }

    public Guid NoncitizenPatientTypeId { get; set; }


    public Guid? NationalityId { get; set; }

    public virtual NonCitizenPatientType NoncitizenPatientType { get; set; } = null!;
}
