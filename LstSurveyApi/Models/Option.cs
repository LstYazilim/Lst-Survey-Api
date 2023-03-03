using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LstSurveyApi.Models;

public partial class Option
{
    public int OptionId { get; set; }

    public string? OptionText { get; set; }

    [JsonPropertyName("question_id")]
    public int? QuestionId { get; set; }

    public virtual Question? Question { get; set; }
}
