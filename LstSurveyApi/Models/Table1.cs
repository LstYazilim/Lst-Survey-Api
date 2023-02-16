using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class Table1
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string Password { get; set; } = null!;
}
