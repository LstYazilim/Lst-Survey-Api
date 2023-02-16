using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class CustomerRole
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? SystemName { get; set; }

    public bool FreeShipping { get; set; }

    public bool TaxExempt { get; set; }

    public bool Active { get; set; }

    public bool IsSystemRole { get; set; }

    public bool EnablePasswordLifetime { get; set; }

    public bool OverrideTaxDisplayType { get; set; }

    public int DefaultTaxDisplayTypeId { get; set; }

    public int PurchasedWithProductId { get; set; }

    public virtual ICollection<AclRecord> AclRecords { get; } = new List<AclRecord>();

    public virtual ICollection<TierPrice> TierPrices { get; } = new List<TierPrice>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<PermissionRecord> PermissionRecords { get; } = new List<PermissionRecord>();
}
