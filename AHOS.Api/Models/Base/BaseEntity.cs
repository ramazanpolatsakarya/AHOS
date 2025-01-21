using System;
using System.Collections;
using System.Collections.Generic;

namespace AHOS.Api.Models.Base;

public partial class BaseEntity
{
    public Guid Id { get; set; }

    public BitArray IsDeleted { get; set; } = null!;

    public DateOnly CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public Guid CreatedTransactionId { get; set; }

    public DateOnly? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public Guid? ModifiedTransactionId { get; set; }

    public DateOnly? DeletedOn { get; set; }

    public Guid? DeletedBy { get; set; }

    public Guid? DeletedTransactionId { get; set; }
}
