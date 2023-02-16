using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class SpecificationAttribute
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? SpecificationAttributeGroupId { get; set; }

    public int DisplayOrder { get; set; }

    public virtual SpecificationAttributeGroup? SpecificationAttributeGroup { get; set; }

    public virtual ICollection<SpecificationAttributeOption> SpecificationAttributeOptions { get; } = new List<SpecificationAttributeOption>();
}
