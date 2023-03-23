using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LstSurveyApi.Models;

public partial class QuestionUnitSurvey
{
    [JsonPropertyName("question_id")]
    [Key]
    public int QuestionId { get; set; }

    [JsonPropertyName("unit_id")]
    public int UnitId { get; set; }

    [JsonPropertyName("survey_id")]
    public int SurveyId { get; set; }

    [ForeignKey("QuestionId")]
    public virtual Question Question { get; set; } = null!;

    public virtual Survey Survey { get; set; } = null!;

    [ForeignKey("UnitId")]
    public virtual Unit Unit { get; set; } = null!;
}
