using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class Unit
{
    public int UnitId { get; set; }

    public string? UnitName { get; set; }

    public virtual ICollection<QuestionUnitSurvey> QuestionUnitSurveys { get; } = new List<QuestionUnitSurvey>();
}
