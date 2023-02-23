using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LstSurveyApi.Models;

public partial class Survey
{
    [JsonPropertyName("survey_id")]
    public int SurveyId { get; set; }

    [JsonPropertyName("survey_name")]
    public string? SurveyName { get; set; }

    [JsonPropertyName("survey_date")]
    public DateTime? SurveyDate { get; set; }

    [JsonPropertyName("create_date")]
    public DateTime? CreateDate { get; set; }

    [JsonPropertyName("update_date")]
    public DateTime? UpdateDate { get; set; }

    [JsonPropertyName("creater_user")]
    public string? CreaterUser { get; set; }

    [JsonPropertyName("updater_user")]
    public string? UpdaterUser { get; set; }

    public virtual ICollection<QuestionUnitSurvey> QuestionUnitSurveys { get; } = new List<QuestionUnitSurvey>();

    public virtual ICollection<SurveyUser> SurveyUsers { get; } = new List<SurveyUser>();
}
