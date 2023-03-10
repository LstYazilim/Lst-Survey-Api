using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LstSurveyApi.Models;

public partial class Halk1342OHalk061020Context : DbContext
{
    public Halk1342OHalk061020Context()
    {
    }

    public Halk1342OHalk061020Context(DbContextOptions<Halk1342OHalk061020Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AclRecord> AclRecords { get; set; }

    public virtual DbSet<ActivityLog> ActivityLogs { get; set; }

    public virtual DbSet<ActivityLogType> ActivityLogTypes { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AddressAttribute> AddressAttributes { get; set; }

    public virtual DbSet<AddressAttributeValue> AddressAttributeValues { get; set; }

    public virtual DbSet<Affiliate> Affiliates { get; set; }

    public virtual DbSet<BackInStockSubscription> BackInStockSubscriptions { get; set; }

    public virtual DbSet<BlogComment> BlogComments { get; set; }

    public virtual DbSet<BlogPost> BlogPosts { get; set; }

    public virtual DbSet<Campaign> Campaigns { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryTemplate> CategoryTemplates { get; set; }

    public virtual DbSet<CheckoutAttribute> CheckoutAttributes { get; set; }

    public virtual DbSet<CheckoutAttributeValue> CheckoutAttributeValues { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CrossSellProduct> CrossSellProducts { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAttribute> CustomerAttributes { get; set; }

    public virtual DbSet<CustomerAttributeValue> CustomerAttributeValues { get; set; }

    public virtual DbSet<CustomerPassword> CustomerPasswords { get; set; }

    public virtual DbSet<CustomerRole> CustomerRoles { get; set; }

    public virtual DbSet<DeliveryDate> DeliveryDates { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<DiscountRequirement> DiscountRequirements { get; set; }

    public virtual DbSet<DiscountUsageHistory> DiscountUsageHistories { get; set; }

    public virtual DbSet<Download> Downloads { get; set; }

    public virtual DbSet<EmailAccount> EmailAccounts { get; set; }

    public virtual DbSet<ExternalAuthenticationRecord> ExternalAuthenticationRecords { get; set; }

    public virtual DbSet<FacebookPixelConfiguration> FacebookPixelConfigurations { get; set; }

    public virtual DbSet<ForumsForum> ForumsForums { get; set; }

    public virtual DbSet<ForumsGroup> ForumsGroups { get; set; }

    public virtual DbSet<ForumsPost> ForumsPosts { get; set; }

    public virtual DbSet<ForumsPostVote> ForumsPostVotes { get; set; }

    public virtual DbSet<ForumsPrivateMessage> ForumsPrivateMessages { get; set; }

    public virtual DbSet<ForumsSubscription> ForumsSubscriptions { get; set; }

    public virtual DbSet<ForumsTopic> ForumsTopics { get; set; }

    public virtual DbSet<GdprConsent> GdprConsents { get; set; }

    public virtual DbSet<GdprLog> GdprLogs { get; set; }

    public virtual DbSet<GenericAttribute> GenericAttributes { get; set; }

    public virtual DbSet<GiftCard> GiftCards { get; set; }

    public virtual DbSet<GiftCardUsageHistory> GiftCardUsageHistories { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LocaleStringResource> LocaleStringResources { get; set; }

    public virtual DbSet<LocalizedProperty> LocalizedProperties { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<ManufacturerTemplate> ManufacturerTemplates { get; set; }

    public virtual DbSet<MeasureDimension> MeasureDimensions { get; set; }

    public virtual DbSet<MeasureWeight> MeasureWeights { get; set; }

    public virtual DbSet<MessageTemplate> MessageTemplates { get; set; }

    public virtual DbSet<MigrationVersionInfo> MigrationVersionInfos { get; set; }

    public virtual DbSet<Müşteriler> Müşterilers { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<NewsComment> NewsComments { get; set; }

    public virtual DbSet<NewsLetterSubscription> NewsLetterSubscriptions { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<OrderNote> OrderNotes { get; set; }

    public virtual DbSet<PermissionRecord> PermissionRecords { get; set; }

    public virtual DbSet<Picture> Pictures { get; set; }

    public virtual DbSet<PictureBinary> PictureBinaries { get; set; }

    public virtual DbSet<Poll> Polls { get; set; }

    public virtual DbSet<PollAnswer> PollAnswers { get; set; }

    public virtual DbSet<PollVotingRecord> PollVotingRecords { get; set; }

    public virtual DbSet<PredefinedProductAttributeValue> PredefinedProductAttributeValues { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }

    public virtual DbSet<ProductAttributeCombination> ProductAttributeCombinations { get; set; }

    public virtual DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }

    public virtual DbSet<ProductAvailabilityRange> ProductAvailabilityRanges { get; set; }

    public virtual DbSet<ProductCategoryMapping> ProductCategoryMappings { get; set; }

    public virtual DbSet<ProductManufacturerMapping> ProductManufacturerMappings { get; set; }

    public virtual DbSet<ProductPictureMapping> ProductPictureMappings { get; set; }

    public virtual DbSet<ProductProductAttributeMapping> ProductProductAttributeMappings { get; set; }

    public virtual DbSet<ProductReview> ProductReviews { get; set; }

    public virtual DbSet<ProductReviewHelpfulness> ProductReviewHelpfulnesses { get; set; }

    public virtual DbSet<ProductReviewReviewTypeMapping> ProductReviewReviewTypeMappings { get; set; }

    public virtual DbSet<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMappings { get; set; }

    public virtual DbSet<ProductTag> ProductTags { get; set; }

    public virtual DbSet<ProductTemplate> ProductTemplates { get; set; }

    public virtual DbSet<ProductWarehouseInventory> ProductWarehouseInventories { get; set; }

    public virtual DbSet<QueuedEmail> QueuedEmails { get; set; }

    public virtual DbSet<RecurringPayment> RecurringPayments { get; set; }

    public virtual DbSet<RecurringPaymentHistory> RecurringPaymentHistories { get; set; }

    public virtual DbSet<RelatedProduct> RelatedProducts { get; set; }

    public virtual DbSet<ReturnRequest> ReturnRequests { get; set; }

    public virtual DbSet<ReturnRequestAction> ReturnRequestActions { get; set; }

    public virtual DbSet<ReturnRequestReason> ReturnRequestReasons { get; set; }

    public virtual DbSet<ReviewType> ReviewTypes { get; set; }

    public virtual DbSet<RewardPointsHistory> RewardPointsHistories { get; set; }

    public virtual DbSet<ScheduleTask> ScheduleTasks { get; set; }

    public virtual DbSet<SearchTerm> SearchTerms { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<Shipment> Shipments { get; set; }

    public virtual DbSet<ShipmentItem> ShipmentItems { get; set; }

    public virtual DbSet<ShippingByWeightByTotalRecord> ShippingByWeightByTotalRecords { get; set; }

    public virtual DbSet<ShippingMethod> ShippingMethods { get; set; }

    public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    public virtual DbSet<SpecificationAttribute> SpecificationAttributes { get; set; }

    public virtual DbSet<SpecificationAttributeGroup> SpecificationAttributeGroups { get; set; }

    public virtual DbSet<SpecificationAttributeOption> SpecificationAttributeOptions { get; set; }

    public virtual DbSet<StateProvince> StateProvinces { get; set; }

    public virtual DbSet<StockQuantityHistory> StockQuantityHistories { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<StoreMapping> StoreMappings { get; set; }

    public virtual DbSet<StorePickupPoint> StorePickupPoints { get; set; }

    public virtual DbSet<Survey> Surveys { get; set; }

    public virtual DbSet<Table1> Table1s { get; set; }

    public virtual DbSet<TaxCategory> TaxCategories { get; set; }

    public virtual DbSet<TierPrice> TierPrices { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<TopicTemplate> TopicTemplates { get; set; }

    public virtual DbSet<UrlRecord> UrlRecords { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    public virtual DbSet<VendorAttribute> VendorAttributes { get; set; }

    public virtual DbSet<VendorAttributeValue> VendorAttributeValues { get; set; }

    public virtual DbSet<VendorNote> VendorNotes { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=37.230.108.246;Database=halk1342_oHalk061020;User ID=skyPeople;Password=pG7@39b@;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("skyPeople");

        modelBuilder.Entity<AclRecord>(entity =>
        {
            entity.ToTable("AclRecord", "dbo");

            entity.HasIndex(e => e.CustomerRoleId, "IX_AclRecord_CustomerRoleId");

            entity.HasIndex(e => new { e.EntityId, e.EntityName }, "IX_AclRecord_EntityId_EntityName");

            entity.Property(e => e.EntityName).HasMaxLength(400);

            //entity.HasOne(d => d.CustomerRole).WithMany(p => p.AclRecords)
              //  .HasForeignKey(d => d.CustomerRoleId)
               // .HasConstraintName("FK_AclRecord_CustomerRoleId_CustomerRole_Id");
        });

        modelBuilder.Entity<ActivityLog>(entity =>
        {
            entity.ToTable("ActivityLog", "dbo");

            entity.HasIndex(e => e.ActivityLogTypeId, "IX_ActivityLog_ActivityLogTypeId");

            entity.HasIndex(e => e.CreatedOnUtc, "IX_ActivityLog_CreatedOnUtc").IsDescending();

            entity.HasIndex(e => e.CustomerId, "IX_ActivityLog_CustomerId");

            entity.Property(e => e.EntityName).HasMaxLength(400);
            entity.Property(e => e.IpAddress).HasMaxLength(200);

            entity.HasOne(d => d.ActivityLogType).WithMany(p => p.ActivityLogs)
                .HasForeignKey(d => d.ActivityLogTypeId)
                .HasConstraintName("FK_ActivityLog_ActivityLogTypeId_ActivityLogType_Id");

            entity.HasOne(d => d.Customer).WithMany(p => p.ActivityLogs)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ActivityLog_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<ActivityLogType>(entity =>
        {
            entity.ToTable("ActivityLogType", "dbo");

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.SystemKeyword).HasMaxLength(100);
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("Address", "dbo");

            entity.HasIndex(e => e.CountryId, "IX_Address_CountryId");

            entity.HasIndex(e => e.StateProvinceId, "IX_Address_StateProvinceId");

            entity.HasOne(d => d.Country).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Address_CountryId_Country_Id");

            entity.HasOne(d => d.StateProvince).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.StateProvinceId)
                .HasConstraintName("FK_Address_StateProvinceId_StateProvince_Id");

            entity.HasMany(d => d.Customers).WithMany(p => p.Addresses)
                .UsingEntity<Dictionary<string, object>>(
                    "CustomerAddress",
                    r => r.HasOne<Customer>().WithMany()
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_CustomerAddresses_Customer_Id_Customer_Id"),
                    l => l.HasOne<Address>().WithMany()
                        .HasForeignKey("AddressId")
                        .HasConstraintName("FK_CustomerAddresses_Address_Id_Address_Id"),
                    j =>
                    {
                        j.HasKey("AddressId", "CustomerId");
                        j.ToTable("CustomerAddresses", "dbo");
                        j.HasIndex(new[] { "AddressId" }, "IX_CustomerAddresses_Address_Id");
                        j.HasIndex(new[] { "CustomerId" }, "IX_CustomerAddresses_Customer_Id");
                        j.IndexerProperty<int>("AddressId").HasColumnName("Address_Id");
                        j.IndexerProperty<int>("CustomerId").HasColumnName("Customer_Id");
                    });
        });

        modelBuilder.Entity<AddressAttribute>(entity =>
        {
            entity.ToTable("AddressAttribute", "dbo");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<AddressAttributeValue>(entity =>
        {
            entity.ToTable("AddressAttributeValue", "dbo");

            entity.HasIndex(e => e.AddressAttributeId, "IX_AddressAttributeValue_AddressAttributeId");

            entity.Property(e => e.Name).HasMaxLength(400);

            entity.HasOne(d => d.AddressAttribute).WithMany(p => p.AddressAttributeValues)
                .HasForeignKey(d => d.AddressAttributeId)
                .HasConstraintName("FK_AddressAttributeValue_AddressAttributeId_AddressAttribute_Id");
        });

        modelBuilder.Entity<Affiliate>(entity =>
        {
            entity.ToTable("Affiliate", "dbo");

            entity.HasIndex(e => e.AddressId, "IX_Affiliate_AddressId");

            entity.HasOne(d => d.Address).WithMany(p => p.Affiliates)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Affiliate_AddressId_Address_Id");
        });

        modelBuilder.Entity<BackInStockSubscription>(entity =>
        {
            entity.ToTable("BackInStockSubscription", "dbo");

            entity.HasIndex(e => e.CustomerId, "IX_BackInStockSubscription_CustomerId");

            entity.HasIndex(e => e.ProductId, "IX_BackInStockSubscription_ProductId");

            entity.HasOne(d => d.Customer).WithMany(p => p.BackInStockSubscriptions)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_BackInStockSubscription_CustomerId_Customer_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.BackInStockSubscriptions)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_BackInStockSubscription_ProductId_Product_Id");
        });

        modelBuilder.Entity<BlogComment>(entity =>
        {
            entity.ToTable("BlogComment", "dbo");

            entity.HasIndex(e => e.BlogPostId, "IX_BlogComment_BlogPostId");

            entity.HasIndex(e => e.CustomerId, "IX_BlogComment_CustomerId");

            entity.HasIndex(e => e.StoreId, "IX_BlogComment_StoreId");

            entity.HasOne(d => d.BlogPost).WithMany(p => p.BlogComments)
                .HasForeignKey(d => d.BlogPostId)
                .HasConstraintName("FK_BlogComment_BlogPostId_BlogPost_Id");

            entity.HasOne(d => d.Customer).WithMany(p => p.BlogComments)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_BlogComment_CustomerId_Customer_Id");

            entity.HasOne(d => d.Store).WithMany(p => p.BlogComments)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_BlogComment_StoreId_Store_Id");
        });

        modelBuilder.Entity<BlogPost>(entity =>
        {
            entity.ToTable("BlogPost", "dbo");

            entity.HasIndex(e => e.LanguageId, "IX_BlogPost_LanguageId");

            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);

            entity.HasOne(d => d.Language).WithMany(p => p.BlogPosts)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_BlogPost_LanguageId_Language_Id");
        });

        modelBuilder.Entity<Campaign>(entity =>
        {
            entity.ToTable("Campaign", "dbo");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category", "dbo");

            entity.HasIndex(e => e.Deleted, "IX_Category_Deleted_Extended");

            entity.HasIndex(e => e.DisplayOrder, "IX_Category_DisplayOrder");

            entity.HasIndex(e => e.LimitedToStores, "IX_Category_LimitedToStores");

            entity.HasIndex(e => e.ParentCategoryId, "IX_Category_ParentCategoryId");

            entity.HasIndex(e => e.SubjectToAcl, "IX_Category_SubjectToAcl");

            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
            entity.Property(e => e.PriceFrom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceRanges).HasMaxLength(50);
            entity.Property(e => e.PriceTo).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CategoryTemplate>(entity =>
        {
            entity.ToTable("CategoryTemplate", "dbo");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ViewPath).HasMaxLength(400);
        });

        modelBuilder.Entity<CheckoutAttribute>(entity =>
        {
            entity.ToTable("CheckoutAttribute", "dbo");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<CheckoutAttributeValue>(entity =>
        {
            entity.ToTable("CheckoutAttributeValue", "dbo");

            entity.HasIndex(e => e.CheckoutAttributeId, "IX_CheckoutAttributeValue_CheckoutAttributeId");

            entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.CheckoutAttribute).WithMany(p => p.CheckoutAttributeValues)
                .HasForeignKey(d => d.CheckoutAttributeId)
                .HasConstraintName("FK_CheckoutAttributeValue_CheckoutAttributeId_CheckoutAttribute_Id");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country", "dbo");

            entity.HasIndex(e => e.DisplayOrder, "IX_Country_DisplayOrder");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.ThreeLetterIsoCode).HasMaxLength(3);
            entity.Property(e => e.TwoLetterIsoCode).HasMaxLength(2);
        });

        modelBuilder.Entity<CrossSellProduct>(entity =>
        {
            entity.ToTable("CrossSellProduct", "dbo");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.ToTable("Currency", "dbo");

            entity.HasIndex(e => e.DisplayOrder, "IX_Currency_DisplayOrder");

            entity.Property(e => e.CurrencyCode).HasMaxLength(5);
            entity.Property(e => e.CustomFormatting).HasMaxLength(50);
            entity.Property(e => e.DisplayLocale).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer", "dbo");

            entity.HasIndex(e => e.BillingAddressId, "IX_Customer_BillingAddress_Id");

            entity.HasIndex(e => e.CreatedOnUtc, "IX_Customer_CreatedOnUtc").IsDescending();

            entity.HasIndex(e => e.CustomerGuid, "IX_Customer_CustomerGuid");

            entity.HasIndex(e => e.Email, "IX_Customer_Email");

            entity.HasIndex(e => e.ShippingAddressId, "IX_Customer_ShippingAddress_Id");

            entity.HasIndex(e => e.SystemName, "IX_Customer_SystemName");

            entity.HasIndex(e => e.Username, "IX_Customer_Username");

            entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddress_Id");
            entity.Property(e => e.Email).HasMaxLength(1000);
            entity.Property(e => e.EmailToRevalidate).HasMaxLength(1000);
            entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddress_Id");
            entity.Property(e => e.SystemName).HasMaxLength(400);
            entity.Property(e => e.Username).HasMaxLength(1000);

            entity.HasOne(d => d.BillingAddress).WithMany(p => p.CustomerBillingAddresses)
                .HasForeignKey(d => d.BillingAddressId)
                .HasConstraintName("FK_Customer_BillingAddress_Id_Address_Id");

            entity.HasOne(d => d.ShippingAddress).WithMany(p => p.CustomerShippingAddresses)
                .HasForeignKey(d => d.ShippingAddressId)
                .HasConstraintName("FK_Customer_ShippingAddress_Id_Address_Id");

            entity.HasMany(d => d.CustomerRoles).WithMany(p => p.Customers)
                .UsingEntity<Dictionary<string, object>>(
                    "CustomerCustomerRoleMapping",
                    r => r.HasOne<CustomerRole>().WithMany()
                        .HasForeignKey("CustomerRoleId")
                        .HasConstraintName("FK_Customer_CustomerRole_Mapping_CustomerRole_Id_CustomerRole_Id"),
                    l => l.HasOne<Customer>().WithMany()
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Customer_CustomerRole_Mapping_Customer_Id_Customer_Id"),
                    j =>
                    {
                        j.HasKey("CustomerId", "CustomerRoleId");
                        j.ToTable("Customer_CustomerRole_Mapping", "dbo");
                        j.HasIndex(new[] { "CustomerRoleId" }, "IX_Customer_CustomerRole_Mapping_CustomerRole_Id");
                        j.HasIndex(new[] { "CustomerId" }, "IX_Customer_CustomerRole_Mapping_Customer_Id");
                        j.IndexerProperty<int>("CustomerId").HasColumnName("Customer_Id");
                        j.IndexerProperty<int>("CustomerRoleId").HasColumnName("CustomerRole_Id");
                    });
        });

        modelBuilder.Entity<CustomerAttribute>(entity =>
        {
            entity.ToTable("CustomerAttribute", "dbo");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<CustomerAttributeValue>(entity =>
        {
            entity.ToTable("CustomerAttributeValue", "dbo");

            entity.HasIndex(e => e.CustomerAttributeId, "IX_CustomerAttributeValue_CustomerAttributeId");

            entity.Property(e => e.Name).HasMaxLength(400);

            entity.HasOne(d => d.CustomerAttribute).WithMany(p => p.CustomerAttributeValues)
                .HasForeignKey(d => d.CustomerAttributeId)
                .HasConstraintName("FK_CustomerAttributeValue_CustomerAttributeId_CustomerAttribute_Id");
        });

        modelBuilder.Entity<CustomerPassword>(entity =>
        {
            entity.ToTable("CustomerPassword", "dbo");

            entity.HasIndex(e => e.CustomerId, "IX_CustomerPassword_CustomerId");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerPasswords)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CustomerPassword_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<CustomerRole>(entity =>
        {
            entity.ToTable("CustomerRole", "dbo");

            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.SystemName).HasMaxLength(255);
        });

        modelBuilder.Entity<DeliveryDate>(entity =>
        {
            entity.ToTable("DeliveryDate", "dbo");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.ToTable("Discount", "dbo");

            entity.Property(e => e.CouponCode).HasMaxLength(100);
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MaximumDiscountAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Name).HasMaxLength(200);

            entity.HasMany(d => d.Categories).WithMany(p => p.Discounts)
                .UsingEntity<Dictionary<string, object>>(
                    "DiscountAppliedToCategory",
                    r => r.HasOne<Category>().WithMany()
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Discount_AppliedToCategories_Category_Id_Category_Id"),
                    l => l.HasOne<Discount>().WithMany()
                        .HasForeignKey("DiscountId")
                        .HasConstraintName("FK_Discount_AppliedToCategories_Discount_Id_Discount_Id"),
                    j =>
                    {
                        j.HasKey("DiscountId", "CategoryId");
                        j.ToTable("Discount_AppliedToCategories", "dbo");
                        j.HasIndex(new[] { "CategoryId" }, "IX_Discount_AppliedToCategories_Category_Id");
                        j.HasIndex(new[] { "DiscountId" }, "IX_Discount_AppliedToCategories_Discount_Id");
                        j.IndexerProperty<int>("DiscountId").HasColumnName("Discount_Id");
                        j.IndexerProperty<int>("CategoryId").HasColumnName("Category_Id");
                    });

            entity.HasMany(d => d.Manufacturers).WithMany(p => p.Discounts)
                .UsingEntity<Dictionary<string, object>>(
                    "DiscountAppliedToManufacturer",
                    r => r.HasOne<Manufacturer>().WithMany()
                        .HasForeignKey("ManufacturerId")
                        .HasConstraintName("FK_Discount_AppliedToManufacturers_Manufacturer_Id_Manufacturer_Id"),
                    l => l.HasOne<Discount>().WithMany()
                        .HasForeignKey("DiscountId")
                        .HasConstraintName("FK_Discount_AppliedToManufacturers_Discount_Id_Discount_Id"),
                    j =>
                    {
                        j.HasKey("DiscountId", "ManufacturerId");
                        j.ToTable("Discount_AppliedToManufacturers", "dbo");
                        j.HasIndex(new[] { "DiscountId" }, "IX_Discount_AppliedToManufacturers_Discount_Id");
                        j.HasIndex(new[] { "ManufacturerId" }, "IX_Discount_AppliedToManufacturers_Manufacturer_Id");
                        j.IndexerProperty<int>("DiscountId").HasColumnName("Discount_Id");
                        j.IndexerProperty<int>("ManufacturerId").HasColumnName("Manufacturer_Id");
                    });

            entity.HasMany(d => d.Products).WithMany(p => p.Discounts)
                .UsingEntity<Dictionary<string, object>>(
                    "DiscountAppliedToProduct",
                    r => r.HasOne<Product>().WithMany()
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Discount_AppliedToProducts_Product_Id_Product_Id"),
                    l => l.HasOne<Discount>().WithMany()
                        .HasForeignKey("DiscountId")
                        .HasConstraintName("FK_Discount_AppliedToProducts_Discount_Id_Discount_Id"),
                    j =>
                    {
                        j.HasKey("DiscountId", "ProductId");
                        j.ToTable("Discount_AppliedToProducts", "dbo");
                        j.HasIndex(new[] { "DiscountId" }, "IX_Discount_AppliedToProducts_Discount_Id");
                        j.HasIndex(new[] { "ProductId" }, "IX_Discount_AppliedToProducts_Product_Id");
                        j.IndexerProperty<int>("DiscountId").HasColumnName("Discount_Id");
                        j.IndexerProperty<int>("ProductId").HasColumnName("Product_Id");
                    });
        });

        modelBuilder.Entity<DiscountRequirement>(entity =>
        {
            entity.ToTable("DiscountRequirement", "dbo");

            entity.HasIndex(e => e.DiscountId, "IX_DiscountRequirement_DiscountId");

            entity.HasIndex(e => e.ParentId, "IX_DiscountRequirement_ParentId");

            entity.HasOne(d => d.Discount).WithMany(p => p.DiscountRequirements)
                .HasForeignKey(d => d.DiscountId)
                .HasConstraintName("FK_DiscountRequirement_DiscountId_Discount_Id");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_DiscountRequirement_ParentId_DiscountRequirement_Id");
        });

        modelBuilder.Entity<DiscountUsageHistory>(entity =>
        {
            entity.ToTable("DiscountUsageHistory", "dbo");

            entity.HasIndex(e => e.DiscountId, "IX_DiscountUsageHistory_DiscountId");

            entity.HasIndex(e => e.OrderId, "IX_DiscountUsageHistory_OrderId");

            entity.HasOne(d => d.Discount).WithMany(p => p.DiscountUsageHistories)
                .HasForeignKey(d => d.DiscountId)
                .HasConstraintName("FK_DiscountUsageHistory_DiscountId_Discount_Id");

            entity.HasOne(d => d.Order).WithMany(p => p.DiscountUsageHistories)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_DiscountUsageHistory_OrderId_Order_Id");
        });

        modelBuilder.Entity<Download>(entity =>
        {
            entity.ToTable("Download", "dbo");
        });

        modelBuilder.Entity<EmailAccount>(entity =>
        {
            entity.ToTable("EmailAccount", "dbo");

            entity.Property(e => e.DisplayName).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Host).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(255);
        });

        modelBuilder.Entity<ExternalAuthenticationRecord>(entity =>
        {
            entity.ToTable("ExternalAuthenticationRecord", "dbo");

            entity.HasIndex(e => e.CustomerId, "IX_ExternalAuthenticationRecord_CustomerId");

            entity.Property(e => e.OauthAccessToken).HasColumnName("OAuthAccessToken");
            entity.Property(e => e.OauthToken).HasColumnName("OAuthToken");

            entity.HasOne(d => d.Customer).WithMany(p => p.ExternalAuthenticationRecords)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ExternalAuthenticationRecord_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<FacebookPixelConfiguration>(entity =>
        {
            entity.ToTable("FacebookPixelConfiguration", "dbo");
        });

        modelBuilder.Entity<ForumsForum>(entity =>
        {
            entity.ToTable("Forums_Forum", "dbo");

            entity.HasIndex(e => e.DisplayOrder, "IX_Forums_Forum_DisplayOrder");

            entity.HasIndex(e => e.ForumGroupId, "IX_Forums_Forum_ForumGroupId");

            entity.Property(e => e.Name).HasMaxLength(200);

            entity.HasOne(d => d.ForumGroup).WithMany(p => p.ForumsForums)
                .HasForeignKey(d => d.ForumGroupId)
                .HasConstraintName("FK_Forums_Forum_ForumGroupId_Forums_Group_Id");
        });

        modelBuilder.Entity<ForumsGroup>(entity =>
        {
            entity.ToTable("Forums_Group", "dbo");

            entity.HasIndex(e => e.DisplayOrder, "IX_Forums_Group_DisplayOrder");

            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ForumsPost>(entity =>
        {
            entity.ToTable("Forums_Post", "dbo");

            entity.HasIndex(e => e.CustomerId, "IX_Forums_Post_CustomerId");

            entity.HasIndex(e => e.TopicId, "IX_Forums_Post_TopicId");

            entity.Property(e => e.Ipaddress)
                .HasMaxLength(100)
                .HasColumnName("IPAddress");

            entity.HasOne(d => d.Customer).WithMany(p => p.ForumsPosts)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forums_Post_CustomerId_Customer_Id");

            entity.HasOne(d => d.Topic).WithMany(p => p.ForumsPosts)
                .HasForeignKey(d => d.TopicId)
                .HasConstraintName("FK_Forums_Post_TopicId_Forums_Topic_Id");
        });

        modelBuilder.Entity<ForumsPostVote>(entity =>
        {
            entity.ToTable("Forums_PostVote", "dbo");

            entity.HasIndex(e => e.ForumPostId, "IX_Forums_PostVote_ForumPostId");

            entity.HasOne(d => d.ForumPost).WithMany(p => p.ForumsPostVotes)
                .HasForeignKey(d => d.ForumPostId)
                .HasConstraintName("FK_Forums_PostVote_ForumPostId_Forums_Post_Id");
        });

        modelBuilder.Entity<ForumsPrivateMessage>(entity =>
        {
            entity.ToTable("Forums_PrivateMessage", "dbo");

            entity.HasIndex(e => e.FromCustomerId, "IX_Forums_PrivateMessage_FromCustomerId");

            entity.HasIndex(e => e.ToCustomerId, "IX_Forums_PrivateMessage_ToCustomerId");

            entity.Property(e => e.Subject).HasMaxLength(450);

            entity.HasOne(d => d.FromCustomer).WithMany(p => p.ForumsPrivateMessageFromCustomers)
                .HasForeignKey(d => d.FromCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forums_PrivateMessage_FromCustomerId_Customer_Id");

            entity.HasOne(d => d.ToCustomer).WithMany(p => p.ForumsPrivateMessageToCustomers)
                .HasForeignKey(d => d.ToCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forums_PrivateMessage_ToCustomerId_Customer_Id");
        });

        modelBuilder.Entity<ForumsSubscription>(entity =>
        {
            entity.ToTable("Forums_Subscription", "dbo");

            entity.HasIndex(e => e.CustomerId, "IX_Forums_Subscription_CustomerId");

            entity.HasIndex(e => e.ForumId, "IX_Forums_Subscription_ForumId");

            entity.HasIndex(e => e.TopicId, "IX_Forums_Subscription_TopicId");

            entity.HasOne(d => d.Customer).WithMany(p => p.ForumsSubscriptions)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forums_Subscription_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<ForumsTopic>(entity =>
        {
            entity.ToTable("Forums_Topic", "dbo");

            entity.HasIndex(e => e.CustomerId, "IX_Forums_Topic_CustomerId");

            entity.HasIndex(e => e.ForumId, "IX_Forums_Topic_ForumId");

            entity.Property(e => e.Subject).HasMaxLength(450);

            entity.HasOne(d => d.Customer).WithMany(p => p.ForumsTopics)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forums_Topic_CustomerId_Customer_Id");

            entity.HasOne(d => d.Forum).WithMany(p => p.ForumsTopics)
                .HasForeignKey(d => d.ForumId)
                .HasConstraintName("FK_Forums_Topic_ForumId_Forums_Forum_Id");
        });

        modelBuilder.Entity<GdprConsent>(entity =>
        {
            entity.ToTable("GdprConsent", "dbo");
        });

        modelBuilder.Entity<GdprLog>(entity =>
        {
            entity.ToTable("GdprLog", "dbo");
        });

        modelBuilder.Entity<GenericAttribute>(entity =>
        {
            entity.ToTable("GenericAttribute", "dbo");

            entity.HasIndex(e => new { e.EntityId, e.KeyGroup }, "IX_GenericAttribute_EntityId_and_KeyGroup");

            entity.Property(e => e.CreatedOrUpdatedDateUtc).HasColumnName("CreatedOrUpdatedDateUTC");
            entity.Property(e => e.Key).HasMaxLength(400);
            entity.Property(e => e.KeyGroup).HasMaxLength(400);
        });

        modelBuilder.Entity<GiftCard>(entity =>
        {
            entity.ToTable("GiftCard", "dbo");

            entity.HasIndex(e => e.PurchasedWithOrderItemId, "IX_GiftCard_PurchasedWithOrderItemId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.PurchasedWithOrderItem).WithMany(p => p.GiftCards)
                .HasForeignKey(d => d.PurchasedWithOrderItemId)
                .HasConstraintName("FK_GiftCard_PurchasedWithOrderItemId_OrderItem_Id");
        });

        modelBuilder.Entity<GiftCardUsageHistory>(entity =>
        {
            entity.ToTable("GiftCardUsageHistory", "dbo");

            entity.HasIndex(e => e.GiftCardId, "IX_GiftCardUsageHistory_GiftCardId");

            entity.HasIndex(e => e.UsedWithOrderId, "IX_GiftCardUsageHistory_UsedWithOrderId");

            entity.Property(e => e.UsedValue).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.GiftCard).WithMany(p => p.GiftCardUsageHistories)
                .HasForeignKey(d => d.GiftCardId)
                .HasConstraintName("FK_GiftCardUsageHistory_GiftCardId_GiftCard_Id");

            entity.HasOne(d => d.UsedWithOrder).WithMany(p => p.GiftCardUsageHistories)
                .HasForeignKey(d => d.UsedWithOrderId)
                .HasConstraintName("FK_GiftCardUsageHistory_UsedWithOrderId_Order_Id");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.ToTable("Language", "dbo");

            entity.HasIndex(e => e.DisplayOrder, "IX_Language_DisplayOrder");

            entity.Property(e => e.FlagImageFileName).HasMaxLength(50);
            entity.Property(e => e.LanguageCulture).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.UniqueSeoCode).HasMaxLength(2);
        });

        modelBuilder.Entity<LocaleStringResource>(entity =>
        {
            entity.ToTable("LocaleStringResource", "dbo");

            entity.HasIndex(e => new { e.ResourceName, e.LanguageId }, "IX_LocaleStringResource");

            entity.HasIndex(e => e.LanguageId, "IX_LocaleStringResource_LanguageId");

            entity.Property(e => e.ResourceName).HasMaxLength(200);

            entity.HasOne(d => d.Language).WithMany(p => p.LocaleStringResources)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_LocaleStringResource_LanguageId_Language_Id");
        });

        modelBuilder.Entity<LocalizedProperty>(entity =>
        {
            entity.ToTable("LocalizedProperty", "dbo");

            entity.HasIndex(e => e.LanguageId, "IX_LocalizedProperty_LanguageId");

            entity.Property(e => e.LocaleKey).HasMaxLength(400);
            entity.Property(e => e.LocaleKeyGroup).HasMaxLength(400);

            entity.HasOne(d => d.Language).WithMany(p => p.LocalizedProperties)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_LocalizedProperty_LanguageId_Language_Id");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.ToTable("Log", "dbo");

            entity.HasIndex(e => e.CreatedOnUtc, "IX_Log_CreatedOnUtc").IsDescending();

            entity.HasIndex(e => e.CustomerId, "IX_Log_CustomerId");

            entity.Property(e => e.IpAddress).HasMaxLength(200);

            entity.HasOne(d => d.Customer).WithMany(p => p.Logs)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Log_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.ToTable("Manufacturer", "dbo");

            entity.HasIndex(e => e.DisplayOrder, "IX_Manufacturer_DisplayOrder");

            entity.HasIndex(e => e.LimitedToStores, "IX_Manufacturer_LimitedToStores");

            entity.HasIndex(e => e.SubjectToAcl, "IX_Manufacturer_SubjectToAcl");

            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
            entity.Property(e => e.PriceFrom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceTo).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<ManufacturerTemplate>(entity =>
        {
            entity.ToTable("ManufacturerTemplate", "dbo");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ViewPath).HasMaxLength(400);
        });

        modelBuilder.Entity<MeasureDimension>(entity =>
        {
            entity.ToTable("MeasureDimension", "dbo");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Ratio).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.SystemKeyword).HasMaxLength(100);
        });

        modelBuilder.Entity<MeasureWeight>(entity =>
        {
            entity.ToTable("MeasureWeight", "dbo");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Ratio).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.SystemKeyword).HasMaxLength(100);
        });

        modelBuilder.Entity<MessageTemplate>(entity =>
        {
            entity.ToTable("MessageTemplate", "dbo");

            entity.Property(e => e.BccEmailAddresses).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Subject).HasMaxLength(1000);
        });

        modelBuilder.Entity<MigrationVersionInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MigrationVersionInfo", "dbo");

            entity.HasIndex(e => e.Version, "UC_Version")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.AppliedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1024);
        });

        modelBuilder.Entity<Müşteriler>(entity =>
        {
            entity.HasKey(e => e.MüşteriId).HasName("PK__Müşteril__8F1B3EFDB9152181");

            entity.ToTable("Müşteriler");

            entity.HasIndex(e => e.Email, "UQ__Müşteril__A9D10534AABF304D").IsUnique();

            entity.Property(e => e.MüşteriId)
                .ValueGeneratedNever()
                .HasColumnName("MüşteriID");
            entity.Property(e => e.Ad).HasMaxLength(50);
            entity.Property(e => e.DoğumTarihi).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Soyad).HasMaxLength(50);
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.ToTable("News", "dbo");

            entity.HasIndex(e => e.LanguageId, "IX_News_LanguageId");

            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);

            entity.HasOne(d => d.Language).WithMany(p => p.News)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_News_LanguageId_Language_Id");
        });

        modelBuilder.Entity<NewsComment>(entity =>
        {
            entity.ToTable("NewsComment", "dbo");

            entity.HasIndex(e => e.CustomerId, "IX_NewsComment_CustomerId");

            entity.HasIndex(e => e.NewsItemId, "IX_NewsComment_NewsItemId");

            entity.HasIndex(e => e.StoreId, "IX_NewsComment_StoreId");

            entity.HasOne(d => d.Customer).WithMany(p => p.NewsComments)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_NewsComment_CustomerId_Customer_Id");

            entity.HasOne(d => d.NewsItem).WithMany(p => p.NewsComments)
                .HasForeignKey(d => d.NewsItemId)
                .HasConstraintName("FK_NewsComment_NewsItemId_News_Id");

            entity.HasOne(d => d.Store).WithMany(p => p.NewsComments)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_NewsComment_StoreId_Store_Id");
        });

        modelBuilder.Entity<NewsLetterSubscription>(entity =>
        {
            entity.ToTable("NewsLetterSubscription", "dbo");

            entity.HasIndex(e => new { e.Email, e.StoreId }, "IX_NewsletterSubscription_Email_StoreId");

            entity.Property(e => e.Email).HasMaxLength(255);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable("Order", "dbo");

            entity.HasIndex(e => e.BillingAddressId, "IX_Order_BillingAddressId");

            entity.HasIndex(e => e.CreatedOnUtc, "IX_Order_CreatedOnUtc").IsDescending();

            entity.HasIndex(e => e.CustomerId, "IX_Order_CustomerId");

            entity.HasIndex(e => e.PickupAddressId, "IX_Order_PickupAddressId");

            entity.HasIndex(e => e.ShippingAddressId, "IX_Order_ShippingAddressId");

            entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderShippingExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderShippingInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubTotalDiscountExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubTotalDiscountInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubtotalExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSubtotalInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderTotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PaymentMethodAdditionalFeeExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PaymentMethodAdditionalFeeInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RefundedAmount).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.BillingAddress).WithMany(p => p.OrderBillingAddresses)
                .HasForeignKey(d => d.BillingAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_BillingAddressId_Address_Id");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_CustomerId_Customer_Id");

            entity.HasOne(d => d.PickupAddress).WithMany(p => p.OrderPickupAddresses)
                .HasForeignKey(d => d.PickupAddressId)
                .HasConstraintName("FK_Order_PickupAddressId_Address_Id");

            entity.HasOne(d => d.RewardPointsHistoryEntry).WithMany(p => p.Orders)
                .HasForeignKey(d => d.RewardPointsHistoryEntryId)
                .HasConstraintName("FK_Order_RewardPointsHistoryEntryId_RewardPointsHistory_Id");

            entity.HasOne(d => d.ShippingAddress).WithMany(p => p.OrderShippingAddresses)
                .HasForeignKey(d => d.ShippingAddressId)
                .HasConstraintName("FK_Order_ShippingAddressId_Address_Id");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.ToTable("OrderItem", "dbo");

            entity.HasIndex(e => e.OrderId, "IX_OrderItem_OrderId");

            entity.HasIndex(e => e.ProductId, "IX_OrderItem_ProductId");

            entity.Property(e => e.DiscountAmountExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DiscountAmountInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ItemWeight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OriginalProductCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceInclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UnitPriceExclTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UnitPriceInclTax).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OrderItem_OrderId_Order_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_OrderItem_ProductId_Product_Id");
        });

        modelBuilder.Entity<OrderNote>(entity =>
        {
            entity.ToTable("OrderNote", "dbo");

            entity.HasIndex(e => e.OrderId, "IX_OrderNote_OrderId");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderNotes)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OrderNote_OrderId_Order_Id");
        });

        modelBuilder.Entity<PermissionRecord>(entity =>
        {
            entity.ToTable("PermissionRecord", "dbo");

            entity.Property(e => e.Category).HasMaxLength(255);
            entity.Property(e => e.SystemName).HasMaxLength(255);

            entity.HasMany(d => d.CustomerRoles).WithMany(p => p.PermissionRecords)
                .UsingEntity<Dictionary<string, object>>(
                    "PermissionRecordRoleMapping",
                    r => r.HasOne<CustomerRole>().WithMany()
                        .HasForeignKey("CustomerRoleId")
                        .HasConstraintName("FK_PermissionRecord_Role_Mapping_CustomerRole_Id_CustomerRole_Id"),
                    l => l.HasOne<PermissionRecord>().WithMany()
                        .HasForeignKey("PermissionRecordId")
                        .HasConstraintName("FK_PermissionRecord_Role_Mapping_PermissionRecord_Id_PermissionRecord_Id"),
                    j =>
                    {
                        j.HasKey("PermissionRecordId", "CustomerRoleId");
                        j.ToTable("PermissionRecord_Role_Mapping", "dbo");
                        j.HasIndex(new[] { "CustomerRoleId" }, "IX_PermissionRecord_Role_Mapping_CustomerRole_Id");
                        j.HasIndex(new[] { "PermissionRecordId" }, "IX_PermissionRecord_Role_Mapping_PermissionRecord_Id");
                        j.IndexerProperty<int>("PermissionRecordId").HasColumnName("PermissionRecord_Id");
                        j.IndexerProperty<int>("CustomerRoleId").HasColumnName("CustomerRole_Id");
                    });
        });

        modelBuilder.Entity<Picture>(entity =>
        {
            entity.ToTable("Picture", "dbo");

            entity.Property(e => e.MimeType).HasMaxLength(40);
            entity.Property(e => e.SeoFilename).HasMaxLength(300);
        });

        modelBuilder.Entity<PictureBinary>(entity =>
        {
            entity.ToTable("PictureBinary", "dbo");

            entity.HasIndex(e => e.PictureId, "IX_PictureBinary_PictureId");

            entity.HasOne(d => d.Picture).WithMany(p => p.PictureBinaries)
                .HasForeignKey(d => d.PictureId)
                .HasConstraintName("FK_PictureBinary_PictureId_Picture_Id");
        });

        modelBuilder.Entity<Poll>(entity =>
        {
            entity.ToTable("Poll", "dbo");

            entity.HasIndex(e => e.LanguageId, "IX_Poll_LanguageId");

            entity.HasOne(d => d.Language).WithMany(p => p.Polls)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_Poll_LanguageId_Language_Id");
        });

        modelBuilder.Entity<PollAnswer>(entity =>
        {
            entity.ToTable("PollAnswer", "dbo");

            entity.HasIndex(e => e.PollId, "IX_PollAnswer_PollId");

            entity.HasOne(d => d.Poll).WithMany(p => p.PollAnswers)
                .HasForeignKey(d => d.PollId)
                .HasConstraintName("FK_PollAnswer_PollId_Poll_Id");
        });

        modelBuilder.Entity<PollVotingRecord>(entity =>
        {
            entity.ToTable("PollVotingRecord", "dbo");

            entity.HasIndex(e => e.CustomerId, "IX_PollVotingRecord_CustomerId");

            entity.HasIndex(e => e.PollAnswerId, "IX_PollVotingRecord_PollAnswerId");

            entity.HasOne(d => d.Customer).WithMany(p => p.PollVotingRecords)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_PollVotingRecord_CustomerId_Customer_Id");

            entity.HasOne(d => d.PollAnswer).WithMany(p => p.PollVotingRecords)
                .HasForeignKey(d => d.PollAnswerId)
                .HasConstraintName("FK_PollVotingRecord_PollAnswerId_PollAnswer_Id");
        });

        modelBuilder.Entity<PredefinedProductAttributeValue>(entity =>
        {
            entity.ToTable("PredefinedProductAttributeValue", "dbo");

            entity.HasIndex(e => e.ProductAttributeId, "IX_PredefinedProductAttributeValue_ProductAttributeId");

            entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.ProductAttribute).WithMany(p => p.PredefinedProductAttributeValues)
                .HasForeignKey(d => d.ProductAttributeId)
                .HasConstraintName("FK_PredefinedProductAttributeValue_ProductAttributeId_ProductAttribute_Id");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product", "dbo");

            entity.HasIndex(e => new { e.Deleted, e.VendorId, e.ProductTypeId, e.ManageInventoryMethodId, e.MinStockQuantity, e.UseMultipleWarehouses }, "IX_GetLowStockProducts");

            entity.HasIndex(e => new { e.Deleted, e.Id }, "IX_Product_Delete_Id");

            entity.HasIndex(e => new { e.Published, e.Deleted }, "IX_Product_Deleted_and_Published");

            entity.HasIndex(e => e.LimitedToStores, "IX_Product_LimitedToStores");

            entity.HasIndex(e => e.ParentGroupedProductId, "IX_Product_ParentGroupedProductId");

            entity.HasIndex(e => new { e.Price, e.AvailableStartDateTimeUtc, e.AvailableEndDateTimeUtc, e.Published, e.Deleted }, "IX_Product_PriceDatesEtc");

            entity.HasIndex(e => e.Published, "IX_Product_Published");

            entity.HasIndex(e => e.ShowOnHomepage, "IX_Product_ShowOnHomepage");

            entity.HasIndex(e => e.SubjectToAcl, "IX_Product_SubjectToAcl");

            entity.HasIndex(e => e.VisibleIndividually, "IX_Product_VisibleIndividually");

            entity.HasIndex(e => new { e.VisibleIndividually, e.Published, e.Deleted }, "IX_Product_VisibleIndividually_Published_Deleted_Extended");

            entity.Property(e => e.AdditionalShippingCharge).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AllowedQuantities).HasMaxLength(1000);
            entity.Property(e => e.BasepriceAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BasepriceBaseAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Gtin).HasMaxLength(400);
            entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);
            entity.Property(e => e.MaximumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.MinimumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OverriddenGiftCardAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RequiredProductIds).HasMaxLength(1000);
            entity.Property(e => e.Sku).HasMaxLength(400);
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");

            entity.HasMany(d => d.ProductTags).WithMany(p => p.Products)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductProductTagMapping",
                    r => r.HasOne<ProductTag>().WithMany()
                        .HasForeignKey("ProductTagId")
                        .HasConstraintName("FK_Product_ProductTag_Mapping_ProductTag_Id_ProductTag_Id"),
                    l => l.HasOne<Product>().WithMany()
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Product_ProductTag_Mapping_Product_Id_Product_Id"),
                    j =>
                    {
                        j.HasKey("ProductId", "ProductTagId");
                        j.ToTable("Product_ProductTag_Mapping", "dbo");
                        j.HasIndex(new[] { "ProductTagId" }, "IX_Product_ProductTag_Mapping_ProductTag_Id");
                        j.HasIndex(new[] { "ProductId" }, "IX_Product_ProductTag_Mapping_Product_Id");
                        j.IndexerProperty<int>("ProductId").HasColumnName("Product_Id");
                        j.IndexerProperty<int>("ProductTagId").HasColumnName("ProductTag_Id");
                    });
        });

        modelBuilder.Entity<ProductAttribute>(entity =>
        {
            entity.ToTable("ProductAttribute", "dbo");
        });

        modelBuilder.Entity<ProductAttributeCombination>(entity =>
        {
            entity.ToTable("ProductAttributeCombination", "dbo");

            entity.HasIndex(e => e.ProductId, "IX_ProductAttributeCombination_ProductId");

            entity.Property(e => e.Gtin).HasMaxLength(400);
            entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);
            entity.Property(e => e.OverriddenPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Sku).HasMaxLength(400);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductAttributeCombinations)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductAttributeCombination_ProductId_Product_Id");
        });

        modelBuilder.Entity<ProductAttributeValue>(entity =>
        {
            entity.ToTable("ProductAttributeValue", "dbo");

            entity.HasIndex(e => e.ProductAttributeMappingId, "IX_ProductAttributeValue_ProductAttributeMappingId");

            entity.HasIndex(e => new { e.ProductAttributeMappingId, e.DisplayOrder }, "IX_ProductAttributeValue_ProductAttributeMappingId_DisplayOrder");

            entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.ProductAttributeMapping).WithMany(p => p.ProductAttributeValues)
                .HasForeignKey(d => d.ProductAttributeMappingId)
                .HasConstraintName("FK_ProductAttributeValue_ProductAttributeMappingId_Product_ProductAttribute_Mapping_Id");
        });

        modelBuilder.Entity<ProductAvailabilityRange>(entity =>
        {
            entity.ToTable("ProductAvailabilityRange", "dbo");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<ProductCategoryMapping>(entity =>
        {
            entity.ToTable("Product_Category_Mapping", "dbo");

            entity.HasIndex(e => new { e.ProductId, e.IsFeaturedProduct }, "IX_PCM_ProductId_Extended");

            entity.HasIndex(e => new { e.CategoryId, e.ProductId }, "IX_PCM_Product_and_Category");

            entity.HasIndex(e => e.CategoryId, "IX_Product_Category_Mapping_CategoryId");

            entity.HasIndex(e => e.IsFeaturedProduct, "IX_Product_Category_Mapping_IsFeaturedProduct");

            entity.HasIndex(e => e.ProductId, "IX_Product_Category_Mapping_ProductId");

            entity.HasOne(d => d.Category).WithMany(p => p.ProductCategoryMappings)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Product_Category_Mapping_CategoryId_Category_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductCategoryMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Product_Category_Mapping_ProductId_Product_Id");
        });

        modelBuilder.Entity<ProductManufacturerMapping>(entity =>
        {
            entity.ToTable("Product_Manufacturer_Mapping", "dbo");

            entity.HasIndex(e => new { e.ProductId, e.IsFeaturedProduct }, "IX_PMM_ProductId_Extended");

            entity.HasIndex(e => new { e.ManufacturerId, e.ProductId }, "IX_PMM_Product_and_Manufacturer");

            entity.HasIndex(e => e.IsFeaturedProduct, "IX_Product_Manufacturer_Mapping_IsFeaturedProduct");

            entity.HasIndex(e => e.ManufacturerId, "IX_Product_Manufacturer_Mapping_ManufacturerId");

            entity.HasIndex(e => e.ProductId, "IX_Product_Manufacturer_Mapping_ProductId");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.ProductManufacturerMappings)
                .HasForeignKey(d => d.ManufacturerId)
                .HasConstraintName("FK_Product_Manufacturer_Mapping_ManufacturerId_Manufacturer_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductManufacturerMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Product_Manufacturer_Mapping_ProductId_Product_Id");
        });

        modelBuilder.Entity<ProductPictureMapping>(entity =>
        {
            entity.ToTable("Product_Picture_Mapping", "dbo");

            entity.HasIndex(e => e.PictureId, "IX_Product_Picture_Mapping_PictureId");

            entity.HasIndex(e => e.ProductId, "IX_Product_Picture_Mapping_ProductId");

            entity.HasOne(d => d.Picture).WithMany(p => p.ProductPictureMappings)
                .HasForeignKey(d => d.PictureId)
                .HasConstraintName("FK_Product_Picture_Mapping_PictureId_Picture_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductPictureMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Product_Picture_Mapping_ProductId_Product_Id");
        });

        modelBuilder.Entity<ProductProductAttributeMapping>(entity =>
        {
            entity.ToTable("Product_ProductAttribute_Mapping", "dbo");

            entity.HasIndex(e => e.ProductAttributeId, "IX_Product_ProductAttribute_Mapping_ProductAttributeId");

            entity.HasIndex(e => e.ProductId, "IX_Product_ProductAttribute_Mapping_ProductId");

            entity.HasIndex(e => new { e.ProductId, e.DisplayOrder }, "IX_Product_ProductAttribute_Mapping_ProductId_DisplayOrder");

            entity.HasOne(d => d.ProductAttribute).WithMany(p => p.ProductProductAttributeMappings)
                .HasForeignKey(d => d.ProductAttributeId)
                .HasConstraintName("FK_Product_ProductAttribute_Mapping_ProductAttributeId_ProductAttribute_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductProductAttributeMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Product_ProductAttribute_Mapping_ProductId_Product_Id");
        });

        modelBuilder.Entity<ProductReview>(entity =>
        {
            entity.ToTable("ProductReview", "dbo");

            entity.HasIndex(e => e.CustomerId, "IX_ProductReview_CustomerId");

            entity.HasIndex(e => e.ProductId, "IX_ProductReview_ProductId");

            entity.HasIndex(e => e.StoreId, "IX_ProductReview_StoreId");

            entity.HasOne(d => d.Customer).WithMany(p => p.ProductReviews)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ProductReview_CustomerId_Customer_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductReviews)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductReview_ProductId_Product_Id");

            entity.HasOne(d => d.Store).WithMany(p => p.ProductReviews)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_ProductReview_StoreId_Store_Id");
        });

        modelBuilder.Entity<ProductReviewHelpfulness>(entity =>
        {
            entity.ToTable("ProductReviewHelpfulness", "dbo");

            entity.HasIndex(e => e.ProductReviewId, "IX_ProductReviewHelpfulness_ProductReviewId");

            entity.HasOne(d => d.ProductReview).WithMany(p => p.ProductReviewHelpfulnesses)
                .HasForeignKey(d => d.ProductReviewId)
                .HasConstraintName("FK_ProductReviewHelpfulness_ProductReviewId_ProductReview_Id");
        });

        modelBuilder.Entity<ProductReviewReviewTypeMapping>(entity =>
        {
            entity.ToTable("ProductReview_ReviewType_Mapping", "dbo");

            entity.HasIndex(e => e.ProductReviewId, "IX_ProductReview_ReviewType_Mapping_ProductReviewId");

            entity.HasIndex(e => e.ReviewTypeId, "IX_ProductReview_ReviewType_Mapping_ReviewTypeId");

            entity.HasOne(d => d.ProductReview).WithMany(p => p.ProductReviewReviewTypeMappings)
                .HasForeignKey(d => d.ProductReviewId)
                .HasConstraintName("FK_ProductReview_ReviewType_Mapping_ProductReviewId_ProductReview_Id");

            entity.HasOne(d => d.ReviewType).WithMany(p => p.ProductReviewReviewTypeMappings)
                .HasForeignKey(d => d.ReviewTypeId)
                .HasConstraintName("FK_ProductReview_ReviewType_Mapping_ReviewTypeId_ReviewType_Id");
        });

        modelBuilder.Entity<ProductSpecificationAttributeMapping>(entity =>
        {
            entity.ToTable("Product_SpecificationAttribute_Mapping", "dbo");

            entity.HasIndex(e => e.AllowFiltering, "IX_PSAM_AllowFiltering");

            entity.HasIndex(e => new { e.SpecificationAttributeOptionId, e.AllowFiltering }, "IX_PSAM_SpecificationAttributeOptionId_AllowFiltering");

            entity.HasIndex(e => e.ProductId, "IX_Product_SpecificationAttribute_Mapping_ProductId");

            entity.HasIndex(e => e.SpecificationAttributeOptionId, "IX_Product_SpecificationAttribute_Mapping_SpecificationAttributeOptionId");

            entity.Property(e => e.CustomValue).HasMaxLength(4000);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductSpecificationAttributeMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Product_SpecificationAttribute_Mapping_ProductId_Product_Id");

            entity.HasOne(d => d.SpecificationAttributeOption).WithMany(p => p.ProductSpecificationAttributeMappings)
                .HasForeignKey(d => d.SpecificationAttributeOptionId)
                .HasConstraintName("FK_Product_SpecificationAttribute_Mapping_SpecificationAttributeOptionId_SpecificationAttributeOption_Id");
        });

        modelBuilder.Entity<ProductTag>(entity =>
        {
            entity.ToTable("ProductTag", "dbo");

            entity.HasIndex(e => e.Name, "IX_ProductTag_Name");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<ProductTemplate>(entity =>
        {
            entity.ToTable("ProductTemplate", "dbo");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ViewPath).HasMaxLength(400);
        });

        modelBuilder.Entity<ProductWarehouseInventory>(entity =>
        {
            entity.ToTable("ProductWarehouseInventory", "dbo");

            entity.HasIndex(e => e.ProductId, "IX_ProductWarehouseInventory_ProductId");

            entity.HasIndex(e => e.WarehouseId, "IX_ProductWarehouseInventory_WarehouseId");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductWarehouseInventories)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductWarehouseInventory_ProductId_Product_Id");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.ProductWarehouseInventories)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK_ProductWarehouseInventory_WarehouseId_Warehouse_Id");
        });

        modelBuilder.Entity<QueuedEmail>(entity =>
        {
            entity.ToTable("QueuedEmail", "dbo");

            entity.HasIndex(e => e.CreatedOnUtc, "IX_QueuedEmail_CreatedOnUtc").IsDescending();

            entity.HasIndex(e => e.EmailAccountId, "IX_QueuedEmail_EmailAccountId");

            entity.HasIndex(e => new { e.SentOnUtc, e.DontSendBeforeDateUtc }, "IX_QueuedEmail_SentOnUtc_DontSendBeforeDateUtc_Extended");

            entity.Property(e => e.Bcc).HasMaxLength(500);
            entity.Property(e => e.Cc)
                .HasMaxLength(500)
                .HasColumnName("CC");
            entity.Property(e => e.From).HasMaxLength(500);
            entity.Property(e => e.FromName).HasMaxLength(500);
            entity.Property(e => e.ReplyTo).HasMaxLength(500);
            entity.Property(e => e.ReplyToName).HasMaxLength(500);
            entity.Property(e => e.Subject).HasMaxLength(1000);
            entity.Property(e => e.To).HasMaxLength(500);
            entity.Property(e => e.ToName).HasMaxLength(500);

            entity.HasOne(d => d.EmailAccount).WithMany(p => p.QueuedEmails)
                .HasForeignKey(d => d.EmailAccountId)
                .HasConstraintName("FK_QueuedEmail_EmailAccountId_EmailAccount_Id");
        });

        modelBuilder.Entity<RecurringPayment>(entity =>
        {
            entity.ToTable("RecurringPayment", "dbo");

            entity.HasIndex(e => e.InitialOrderId, "IX_RecurringPayment_InitialOrderId");

            entity.HasOne(d => d.InitialOrder).WithMany(p => p.RecurringPayments)
                .HasForeignKey(d => d.InitialOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecurringPayment_InitialOrderId_Order_Id");
        });

        modelBuilder.Entity<RecurringPaymentHistory>(entity =>
        {
            entity.ToTable("RecurringPaymentHistory", "dbo");

            entity.HasIndex(e => e.RecurringPaymentId, "IX_RecurringPaymentHistory_RecurringPaymentId");

            entity.HasOne(d => d.RecurringPayment).WithMany(p => p.RecurringPaymentHistories)
                .HasForeignKey(d => d.RecurringPaymentId)
                .HasConstraintName("FK_RecurringPaymentHistory_RecurringPaymentId_RecurringPayment_Id");
        });

        modelBuilder.Entity<RelatedProduct>(entity =>
        {
            entity.ToTable("RelatedProduct", "dbo");

            entity.HasIndex(e => e.ProductId1, "IX_RelatedProduct_ProductId1");
        });

        modelBuilder.Entity<ReturnRequest>(entity =>
        {
            entity.ToTable("ReturnRequest", "dbo");

            entity.HasIndex(e => e.CustomerId, "IX_ReturnRequest_CustomerId");

            entity.HasOne(d => d.Customer).WithMany(p => p.ReturnRequests)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ReturnRequest_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<ReturnRequestAction>(entity =>
        {
            entity.ToTable("ReturnRequestAction", "dbo");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<ReturnRequestReason>(entity =>
        {
            entity.ToTable("ReturnRequestReason", "dbo");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<ReviewType>(entity =>
        {
            entity.ToTable("ReviewType", "dbo");

            entity.Property(e => e.Description).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<RewardPointsHistory>(entity =>
        {
            entity.ToTable("RewardPointsHistory", "dbo");

            entity.HasIndex(e => e.CustomerId, "IX_RewardPointsHistory_CustomerId");

            entity.Property(e => e.UsedAmount).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Customer).WithMany(p => p.RewardPointsHistories)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_RewardPointsHistory_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<ScheduleTask>(entity =>
        {
            entity.ToTable("ScheduleTask", "dbo");
        });

        modelBuilder.Entity<SearchTerm>(entity =>
        {
            entity.ToTable("SearchTerm", "dbo");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.ToTable("Setting", "dbo");

            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Shipment>(entity =>
        {
            entity.ToTable("Shipment", "dbo");

            entity.HasIndex(e => e.OrderId, "IX_Shipment_OrderId");

            entity.Property(e => e.TotalWeight).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Order).WithMany(p => p.Shipments)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_Shipment_OrderId_Order_Id");
        });

        modelBuilder.Entity<ShipmentItem>(entity =>
        {
            entity.ToTable("ShipmentItem", "dbo");

            entity.HasIndex(e => e.ShipmentId, "IX_ShipmentItem_ShipmentId");

            entity.HasOne(d => d.Shipment).WithMany(p => p.ShipmentItems)
                .HasForeignKey(d => d.ShipmentId)
                .HasConstraintName("FK_ShipmentItem_ShipmentId_Shipment_Id");
        });

        modelBuilder.Entity<ShippingByWeightByTotalRecord>(entity =>
        {
            entity.ToTable("ShippingByWeightByTotalRecord", "dbo");

            entity.Property(e => e.AdditionalFixedCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LowerWeightLimit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderSubtotalFrom).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderSubtotalTo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PercentageRateOfSubtotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RatePerWeightUnit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WeightFrom).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WeightTo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Zip).HasMaxLength(400);
        });

        modelBuilder.Entity<ShippingMethod>(entity =>
        {
            entity.ToTable("ShippingMethod", "dbo");

            entity.Property(e => e.Name).HasMaxLength(400);

            entity.HasMany(d => d.Countries).WithMany(p => p.ShippingMethods)
                .UsingEntity<Dictionary<string, object>>(
                    "ShippingMethodRestriction",
                    r => r.HasOne<Country>().WithMany()
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK_ShippingMethodRestrictions_Country_Id_Country_Id"),
                    l => l.HasOne<ShippingMethod>().WithMany()
                        .HasForeignKey("ShippingMethodId")
                        .HasConstraintName("FK_ShippingMethodRestrictions_ShippingMethod_Id_ShippingMethod_Id"),
                    j =>
                    {
                        j.HasKey("ShippingMethodId", "CountryId");
                        j.ToTable("ShippingMethodRestrictions", "dbo");
                        j.HasIndex(new[] { "CountryId" }, "IX_ShippingMethodRestrictions_Country_Id");
                        j.HasIndex(new[] { "ShippingMethodId" }, "IX_ShippingMethodRestrictions_ShippingMethod_Id");
                        j.IndexerProperty<int>("ShippingMethodId").HasColumnName("ShippingMethod_Id");
                        j.IndexerProperty<int>("CountryId").HasColumnName("Country_Id");
                    });
        });

        modelBuilder.Entity<ShoppingCartItem>(entity =>
        {
            entity.ToTable("ShoppingCartItem", "dbo");

            entity.HasIndex(e => e.CustomerId, "IX_ShoppingCartItem_CustomerId");

            entity.HasIndex(e => e.ProductId, "IX_ShoppingCartItem_ProductId");

            entity.HasIndex(e => new { e.ShoppingCartTypeId, e.CustomerId }, "IX_ShoppingCartItem_ShoppingCartTypeId_CustomerId");

            entity.Property(e => e.CustomerEnteredPrice).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Customer).WithMany(p => p.ShoppingCartItems)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ShoppingCartItem_CustomerId_Customer_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ShoppingCartItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ShoppingCartItem_ProductId_Product_Id");
        });

        modelBuilder.Entity<SpecificationAttribute>(entity =>
        {
            entity.ToTable("SpecificationAttribute", "dbo");

            entity.HasIndex(e => e.SpecificationAttributeGroupId, "IX_SpecificationAttribute_SpecificationAttributeGroupId");

            entity.HasOne(d => d.SpecificationAttributeGroup).WithMany(p => p.SpecificationAttributes)
                .HasForeignKey(d => d.SpecificationAttributeGroupId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SpecificationAttribute_SpecificationAttributeGroupId_SpecificationAttributeGroup_Id");
        });

        modelBuilder.Entity<SpecificationAttributeGroup>(entity =>
        {
            entity.ToTable("SpecificationAttributeGroup", "dbo");
        });

        modelBuilder.Entity<SpecificationAttributeOption>(entity =>
        {
            entity.ToTable("SpecificationAttributeOption", "dbo");

            entity.HasIndex(e => e.SpecificationAttributeId, "IX_SpecificationAttributeOption_SpecificationAttributeId");

            entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

            entity.HasOne(d => d.SpecificationAttribute).WithMany(p => p.SpecificationAttributeOptions)
                .HasForeignKey(d => d.SpecificationAttributeId)
                .HasConstraintName("FK_SpecificationAttributeOption_SpecificationAttributeId_SpecificationAttribute_Id");
        });

        modelBuilder.Entity<StateProvince>(entity =>
        {
            entity.ToTable("StateProvince", "dbo");

            entity.HasIndex(e => e.CountryId, "IX_StateProvince_CountryId");

            entity.Property(e => e.Abbreviation).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Country).WithMany(p => p.StateProvinces)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_StateProvince_CountryId_Country_Id");
        });

        modelBuilder.Entity<StockQuantityHistory>(entity =>
        {
            entity.ToTable("StockQuantityHistory", "dbo");

            entity.HasIndex(e => e.ProductId, "IX_StockQuantityHistory_ProductId");

            entity.HasOne(d => d.Product).WithMany(p => p.StockQuantityHistories)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_StockQuantityHistory_ProductId_Product_Id");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.ToTable("Store", "dbo");

            entity.Property(e => e.CompanyAddress).HasMaxLength(1000);
            entity.Property(e => e.CompanyName).HasMaxLength(1000);
            entity.Property(e => e.CompanyPhoneNumber).HasMaxLength(1000);
            entity.Property(e => e.CompanyVat).HasMaxLength(1000);
            entity.Property(e => e.Hosts).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.Url).HasMaxLength(400);
        });

        modelBuilder.Entity<StoreMapping>(entity =>
        {
            entity.ToTable("StoreMapping", "dbo");

            entity.HasIndex(e => new { e.EntityId, e.EntityName }, "IX_StoreMapping_EntityId_EntityName");

            entity.HasIndex(e => e.StoreId, "IX_StoreMapping_StoreId");

            entity.Property(e => e.EntityName).HasMaxLength(400);

            entity.HasOne(d => d.Store).WithMany(p => p.StoreMappings)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_StoreMapping_StoreId_Store_Id");
        });

        modelBuilder.Entity<StorePickupPoint>(entity =>
        {
            entity.ToTable("StorePickupPoint", "dbo");

            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PickupFee).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Survey>(entity =>
        {
            entity.ToTable("Survey");

           
        });

        modelBuilder.Entity<Table1>(entity =>
        {
            entity.ToTable("Table_1");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("password");
        });

        modelBuilder.Entity<TaxCategory>(entity =>
        {
            entity.ToTable("TaxCategory", "dbo");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<TierPrice>(entity =>
        {
            entity.ToTable("TierPrice", "dbo");

            entity.HasIndex(e => e.CustomerRoleId, "IX_TierPrice_CustomerRoleId");

            entity.HasIndex(e => e.ProductId, "IX_TierPrice_ProductId");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.CustomerRole).WithMany(p => p.TierPrices)
                .HasForeignKey(d => d.CustomerRoleId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TierPrice_CustomerRoleId_CustomerRole_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.TierPrices)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_TierPrice_ProductId_Product_Id");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.ToTable("Topic", "dbo");
        });

        modelBuilder.Entity<TopicTemplate>(entity =>
        {
            entity.ToTable("TopicTemplate", "dbo");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ViewPath).HasMaxLength(400);
        });

        modelBuilder.Entity<UrlRecord>(entity =>
        {
            entity.ToTable("UrlRecord", "dbo");

            entity.HasIndex(e => new { e.EntityId, e.EntityName, e.LanguageId, e.IsActive }, "IX_UrlRecord_Custom_1");

            entity.HasIndex(e => e.Slug, "IX_UrlRecord_Slug");

            entity.Property(e => e.EntityName).HasMaxLength(400);
            entity.Property(e => e.Slug).HasMaxLength(400);
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.ToTable("Vendor", "dbo");

            entity.Property(e => e.Email).HasMaxLength(400);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
            entity.Property(e => e.PriceFrom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceTo).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<VendorAttribute>(entity =>
        {
            entity.ToTable("VendorAttribute", "dbo");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<VendorAttributeValue>(entity =>
        {
            entity.ToTable("VendorAttributeValue", "dbo");

            entity.HasIndex(e => e.VendorAttributeId, "IX_VendorAttributeValue_VendorAttributeId");

            entity.Property(e => e.Name).HasMaxLength(400);

            entity.HasOne(d => d.VendorAttribute).WithMany(p => p.VendorAttributeValues)
                .HasForeignKey(d => d.VendorAttributeId)
                .HasConstraintName("FK_VendorAttributeValue_VendorAttributeId_VendorAttribute_Id");
        });

        modelBuilder.Entity<VendorNote>(entity =>
        {
            entity.ToTable("VendorNote", "dbo");

            entity.HasIndex(e => e.VendorId, "IX_VendorNote_VendorId");

            entity.HasOne(d => d.Vendor).WithMany(p => p.VendorNotes)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_VendorNote_VendorId_Vendor_Id");
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.ToTable("Warehouse", "dbo");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
