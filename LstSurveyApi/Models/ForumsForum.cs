﻿using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class ForumsForum
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ForumGroupId { get; set; }

    public string? Description { get; set; }

    public int NumTopics { get; set; }

    public int NumPosts { get; set; }

    public int LastTopicId { get; set; }

    public int LastPostId { get; set; }

    public int LastPostCustomerId { get; set; }

    public DateTime? LastPostTime { get; set; }

    public int DisplayOrder { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public DateTime UpdatedOnUtc { get; set; }

    public virtual ForumsGroup ForumGroup { get; set; } = null!;

    public virtual ICollection<ForumsTopic> ForumsTopics { get; } = new List<ForumsTopic>();
}
