using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class SpecificationAttributeOption
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? ColorSquaresRgb { get; set; }

    public int SpecificationAttributeId { get; set; }

    public int DisplayOrder { get; set; }

    public virtual ICollection<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMappings { get; } = new List<ProductSpecificationAttributeMapping>();

    public virtual SpecificationAttribute SpecificationAttribute { get; set; } = null!;
}
