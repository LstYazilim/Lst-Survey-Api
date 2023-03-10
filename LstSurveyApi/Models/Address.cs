using System;
using System.Collections.Generic;

namespace LstSurveyApi.Models;

public partial class Address
{
    public int Id { get; set; }

    public int? CountryId { get; set; }

    public int? StateProvinceId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Company { get; set; }

    public string? County { get; set; }

    public string? City { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? ZipPostalCode { get; set; }

    public string? PhoneNumber { get; set; }

    public string? FaxNumber { get; set; }

    public string? CustomAttributes { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public virtual ICollection<Affiliate> Affiliates { get; } = new List<Affiliate>();

    public virtual Country? Country { get; set; }

    public virtual ICollection<Customer> CustomerBillingAddresses { get; } = new List<Customer>();

    public virtual ICollection<Customer> CustomerShippingAddresses { get; } = new List<Customer>();

    public virtual ICollection<Order> OrderBillingAddresses { get; } = new List<Order>();

    public virtual ICollection<Order> OrderPickupAddresses { get; } = new List<Order>();

    public virtual ICollection<Order> OrderShippingAddresses { get; } = new List<Order>();

    public virtual StateProvince? StateProvince { get; set; }

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();
}
