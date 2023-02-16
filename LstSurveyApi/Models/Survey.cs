using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LstSurveyApi.Models;

[Table("Survey", Schema = "skyPeople")]
public partial class Survey
{

    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("QuestionId")]

    public int QuestionId { get; set; }

    [JsonPropertyName("Question")]

    public string? Question { get; set; }

    [JsonPropertyName("Option1")]

    public string? Option1 { get; set; }

    [JsonPropertyName("Option2")]

    public string? Option2 { get; set; }

    [JsonPropertyName("Option3")]

    public string? Option3 { get; set; }
}
