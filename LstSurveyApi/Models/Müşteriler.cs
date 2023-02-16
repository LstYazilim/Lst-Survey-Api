using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class Müşteriler
{
    public int MüşteriId { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public DateTime? DoğumTarihi { get; set; }

    public string? Email { get; set; }
}
