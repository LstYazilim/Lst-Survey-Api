﻿using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class MeasureWeight
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string SystemKeyword { get; set; } = null!;

    public decimal Ratio { get; set; }

    public int DisplayOrder { get; set; }
}
