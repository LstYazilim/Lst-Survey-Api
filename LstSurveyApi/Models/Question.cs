using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class Question
{
    public int QuestionId { get; set; }

    public string? QuestionText { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? CreaterUser { get; set; }

    public string? UpdaterUser { get; set; }

    public virtual ICollection<QuestionUnitSurvey> QuestionUnitSurveys { get; } = new List<QuestionUnitSurvey>();
}
