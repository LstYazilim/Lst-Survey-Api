﻿using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class VendorAttribute
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsRequired { get; set; }

    public int DisplayOrder { get; set; }

    public int AttributeControlTypeId { get; set; }

    public virtual ICollection<VendorAttributeValue> VendorAttributeValues { get; } = new List<VendorAttributeValue>();
}
