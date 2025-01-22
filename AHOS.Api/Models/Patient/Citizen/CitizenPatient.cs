using System;
using System.Collections;
using System.Collections.Generic;
using AHOS.Api.Models.Base;
using AHOS.Api.Models.Patient.Base;

namespace AHOS.Api.Models.Patient.Citizen;
public partial class CitizenPatient : BasePatient
{
    public long IdentityNumber { get; set; }


}
