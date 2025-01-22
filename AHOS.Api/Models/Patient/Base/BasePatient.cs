using System.Collections;
using AHOS.Api.Models.Base;
using AHOS.Api.Models.Common;

namespace AHOS.Api.Models.Patient.Base;

public partial class BasePatient : BaseEntity
{

    public BitArray Active { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public Guid GenderId { get; set; }

    public DateOnly BirthDate { get; set; }

    public string BirthPlace { get; set; } = null!;

    public BitArray Deceased { get; set; }


    public string PhoneNumber { get; set; } = null!;

    public virtual Gender Gender { get; set; } = null!;
}
