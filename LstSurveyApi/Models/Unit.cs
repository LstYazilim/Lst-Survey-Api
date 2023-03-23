using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LstSurveyApi.Models;

public partial class Unit
{
    [JsonPropertyName("unit_id")]
    public int UnitId { get; set; }

    [JsonPropertyName("unit_name")]
    public string? UnitName { get; set; }

    public virtual ICollection<QuestionUnitSurvey> QuestionUnitSurveys { get; } = new List<QuestionUnitSurvey>();
}
