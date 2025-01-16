using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http;

public class SellerRegistrationViewModel
{
    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Email Address")]
    public string Email { get; set; }

    [Required]
    [Phone]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; }

    [Required]
    [Display(Name = "Business Name")]
    public string BusinessName { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid number of properties.")]
    [Display(Name = "Number of Properties to List")]
    public int NumberOfProperties { get; set; }

    [Display(Name = "Property Image")]
    public IFormFile PropertyImage { get; set; } // For handling file uploads (property image)

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Passwords do not match.")]
    [Display(Name = "Confirm Password")]
    public string ConfirmPassword { get; set; }
}
