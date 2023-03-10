using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class Discount
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? CouponCode { get; set; }

    public string? AdminComment { get; set; }

    public int DiscountTypeId { get; set; }

    public bool UsePercentage { get; set; }

    public decimal DiscountPercentage { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal? MaximumDiscountAmount { get; set; }

    public DateTime? StartDateUtc { get; set; }

    public DateTime? EndDateUtc { get; set; }

    public bool RequiresCouponCode { get; set; }

    public bool IsCumulative { get; set; }

    public int DiscountLimitationId { get; set; }

    public int LimitationTimes { get; set; }

    public int? MaximumDiscountedQuantity { get; set; }

    public bool AppliedToSubCategories { get; set; }

    public virtual ICollection<DiscountRequirement> DiscountRequirements { get; } = new List<DiscountRequirement>();

    public virtual ICollection<DiscountUsageHistory> DiscountUsageHistories { get; } = new List<DiscountUsageHistory>();

    public virtual ICollection<Category> Categories { get; } = new List<Category>();

    public virtual ICollection<Manufacturer> Manufacturers { get; } = new List<Manufacturer>();

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
