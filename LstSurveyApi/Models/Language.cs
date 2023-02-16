using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class Language
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string LanguageCulture { get; set; } = null!;

    public string? UniqueSeoCode { get; set; }

    public string? FlagImageFileName { get; set; }

    public bool Rtl { get; set; }

    public bool LimitedToStores { get; set; }

    public int DefaultCurrencyId { get; set; }

    public bool Published { get; set; }

    public int DisplayOrder { get; set; }

    public virtual ICollection<BlogPost> BlogPosts { get; } = new List<BlogPost>();

    public virtual ICollection<LocaleStringResource> LocaleStringResources { get; } = new List<LocaleStringResource>();

    public virtual ICollection<LocalizedProperty> LocalizedProperties { get; } = new List<LocalizedProperty>();

    public virtual ICollection<News> News { get; } = new List<News>();

    public virtual ICollection<Poll> Polls { get; } = new List<Poll>();
}
