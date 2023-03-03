using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class Option
{
    public int OptionId { get; set; }

    public string? OptionText { get; set; }

    public int? QuestionId { get; set; }

    public virtual Question? Question { get; set; }
}
