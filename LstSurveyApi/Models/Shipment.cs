using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class Shipment
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public string? TrackingNumber { get; set; }

    public decimal? TotalWeight { get; set; }

    public DateTime? ShippedDateUtc { get; set; }

    public DateTime? DeliveryDateUtc { get; set; }

    public string? AdminComment { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual ICollection<ShipmentItem> ShipmentItems { get; } = new List<ShipmentItem>();
}
