using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class UserAnswer
{
    public int AnswerId { get; set; }

    public string? AnswerText { get; set; }

    public int? UserId { get; set; }

    public int? QuestionId { get; set; }

    public int? SurveyId { get; set; }
}
