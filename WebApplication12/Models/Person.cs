using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    public class Person
    {
        [ValidateNever]
        public bool TermsOfService { get; set; }

        [CreditCard]
        public string CreditCardNumber { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }

        [RegularExpression(@"^\w+$")]
        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Url]
        public string Website { get; set; }

        [Remote("CheckUniqueUsername", "Home")]
        public string UniqueUsername { get; set; }
    }
}
