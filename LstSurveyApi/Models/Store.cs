using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class Store
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string? Hosts { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyAddress { get; set; }

    public string? CompanyPhoneNumber { get; set; }

    public string? CompanyVat { get; set; }

    public bool SslEnabled { get; set; }

    public int DefaultLanguageId { get; set; }

    public int DisplayOrder { get; set; }

    public string? CompanyEmail { get; set; }

    public virtual ICollection<BlogComment> BlogComments { get; } = new List<BlogComment>();

    public virtual ICollection<NewsComment> NewsComments { get; } = new List<NewsComment>();

    public virtual ICollection<ProductReview> ProductReviews { get; } = new List<ProductReview>();

    public virtual ICollection<StoreMapping> StoreMappings { get; } = new List<StoreMapping>();
}
