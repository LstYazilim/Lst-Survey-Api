using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class SurveyUser
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserPassword { get; set; }

    public int? SurveyId { get; set; }

    public virtual Survey? Survey { get; set; }
}
