using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class ProductAttribute
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<PredefinedProductAttributeValue> PredefinedProductAttributeValues { get; } = new List<PredefinedProductAttributeValue>();

    public virtual ICollection<ProductProductAttributeMapping> ProductProductAttributeMappings { get; } = new List<ProductProductAttributeMapping>();
}
