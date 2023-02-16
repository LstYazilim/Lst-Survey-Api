using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class ForumsGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public DateTime UpdatedOnUtc { get; set; }

    public virtual ICollection<ForumsForum> ForumsForums { get; } = new List<ForumsForum>();
}
