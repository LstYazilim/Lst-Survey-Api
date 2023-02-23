using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class QuestionUnitSurvey
{
    public int QuestionId { get; set; }

    public int UnitId { get; set; }

    public int SurveyId { get; set; }

    public virtual Question Question { get; set; } = null!;

    public virtual Survey Survey { get; set; } = null!;

    public virtual Unit Unit { get; set; } = null!;
}
