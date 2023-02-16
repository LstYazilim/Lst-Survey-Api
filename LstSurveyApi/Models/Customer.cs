using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? EmailToRevalidate { get; set; }

    public string? SystemName { get; set; }

    public int? BillingAddressId { get; set; }

    public int? ShippingAddressId { get; set; }

    public Guid CustomerGuid { get; set; }

    public string? AdminComment { get; set; }

    public bool IsTaxExempt { get; set; }

    public int AffiliateId { get; set; }

    public int VendorId { get; set; }

    public bool HasShoppingCartItems { get; set; }

    public bool RequireReLogin { get; set; }

    public int FailedLoginAttempts { get; set; }

    public DateTime? CannotLoginUntilDateUtc { get; set; }

    public bool Active { get; set; }

    public bool Deleted { get; set; }

    public bool IsSystemAccount { get; set; }

    public string? LastIpAddress { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public DateTime? LastLoginDateUtc { get; set; }

    public DateTime LastActivityDateUtc { get; set; }

    public int RegisteredInStoreId { get; set; }

    public virtual ICollection<ActivityLog> ActivityLogs { get; } = new List<ActivityLog>();

    public virtual ICollection<BackInStockSubscription> BackInStockSubscriptions { get; } = new List<BackInStockSubscription>();

    public virtual Address? BillingAddress { get; set; }

    public virtual ICollection<BlogComment> BlogComments { get; } = new List<BlogComment>();

    public virtual ICollection<CustomerPassword> CustomerPasswords { get; } = new List<CustomerPassword>();

    public virtual ICollection<ExternalAuthenticationRecord> ExternalAuthenticationRecords { get; } = new List<ExternalAuthenticationRecord>();

    public virtual ICollection<ForumsPost> ForumsPosts { get; } = new List<ForumsPost>();

    public virtual ICollection<ForumsPrivateMessage> ForumsPrivateMessageFromCustomers { get; } = new List<ForumsPrivateMessage>();

    public virtual ICollection<ForumsPrivateMessage> ForumsPrivateMessageToCustomers { get; } = new List<ForumsPrivateMessage>();

    public virtual ICollection<ForumsSubscription> ForumsSubscriptions { get; } = new List<ForumsSubscription>();

    public virtual ICollection<ForumsTopic> ForumsTopics { get; } = new List<ForumsTopic>();

    public virtual ICollection<Log> Logs { get; } = new List<Log>();

    public virtual ICollection<NewsComment> NewsComments { get; } = new List<NewsComment>();

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual ICollection<PollVotingRecord> PollVotingRecords { get; } = new List<PollVotingRecord>();

    public virtual ICollection<ProductReview> ProductReviews { get; } = new List<ProductReview>();

    public virtual ICollection<ReturnRequest> ReturnRequests { get; } = new List<ReturnRequest>();

    public virtual ICollection<RewardPointsHistory> RewardPointsHistories { get; } = new List<RewardPointsHistory>();

    public virtual Address? ShippingAddress { get; set; }

    public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; } = new List<ShoppingCartItem>();

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual ICollection<CustomerRole> CustomerRoles { get; } = new List<CustomerRole>();
}
