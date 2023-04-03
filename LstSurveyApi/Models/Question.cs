using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LstSurveyApi.Models;

public partial class Question
{
    [JsonPropertyName("question_id")]
    public int QuestionId { get; set; }

    [JsonPropertyName("question_text")]
    public string? QuestionText { get; set; }

    [JsonPropertyName("create_date")]
    public DateTime? CreateDate { get; set; }

    [JsonPropertyName("update_date")]
    public DateTime? UpdateDate { get; set; }

    [JsonPropertyName("creater_user")]
    public string? CreaterUser { get; set; }

    [JsonPropertyName("updater_user")]
    public string? UpdaterUser { get; set; }

    public virtual ICollection<QuestionUnitSurvey> QuestionUnitSurveys { get; } = new List<QuestionUnitSurvey>();

}
