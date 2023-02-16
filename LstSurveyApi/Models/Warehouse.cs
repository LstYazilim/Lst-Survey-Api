using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class Warehouse
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? AdminComment { get; set; }

    public int AddressId { get; set; }

    public virtual ICollection<ProductWarehouseInventory> ProductWarehouseInventories { get; } = new List<ProductWarehouseInventory>();
}
