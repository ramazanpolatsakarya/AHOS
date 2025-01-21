using System;
using System.Collections.Generic;
using AHOS.Api.Models.Base;
using AHOS.Api.Models.Common;

namespace AHOS.Api.Models.Patient;

public partial class CitizenApplicationService : BaseEntity
{
    public Guid Id { get; set; }

    public Guid CitizenApplicationId { get; set; }

    public Guid ServiceId { get; set; }


    // buradaki amaç her servis için farklı bir aile hekimi seçebilir.
    public Guid FamilyDoctorId { get; set; }

    public double Price { get; set; }

    public Guid? CityId { get; set; }

    public string ServiceReferanceCode { get; set; } = null!;

    public virtual CitizenApplication CitizenApplication { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;
    public virtual FamilyDoctor FamilyDoctor { get; set; } = null!;
}
