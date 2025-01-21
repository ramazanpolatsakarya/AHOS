﻿using System;
using System.Collections.Generic;
using AHOS.Api.Models.Base;
using AHOS.Api.Models.Common;

namespace AHOS.Api.Models.Patient;

public partial class CitizenApplicationService : BaseEntity
{
    public Guid Id { get; set; }

    public Guid CitizenApplicationId { get; set; }

    public Guid ServiceId { get; set; }


    // her servis için farklı bir aile hekimi seçebilir.
    public Guid FamilyDoctorId { get; set; }
    // ücret olarak hizmetin son durumuna göre çekilecek
    public double Price { get; set; }

    // aile hekimi üzerinden şehri tekrar sorgulamayalım.. burdan filtreleyelim. ilerde de kullanılacaktır.
    public Guid? CityId { get; set; }


    // Bankaya göndereceğimiz referans kodu

    public string ServiceReferanceCode { get; set; } = null!;

    public virtual CitizenApplication CitizenApplication { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;
    public virtual FamilyDoctor FamilyDoctor { get; set; } = null!;
}
