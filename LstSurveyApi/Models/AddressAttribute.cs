using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class AddressAttribute
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsRequired { get; set; }

    public int AttributeControlTypeId { get; set; }

    public int DisplayOrder { get; set; }

    public virtual ICollection<AddressAttributeValue> AddressAttributeValues { get; } = new List<AddressAttributeValue>();
}
