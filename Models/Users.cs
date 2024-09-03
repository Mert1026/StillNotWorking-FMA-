using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Common;
using Microsoft.AspNetCore.Identity;

namespace Models
{
    public class Users : IdentityUser
    {
        //[Key]
        //[Required]
        //public int id { get; set; }

        [Required]
        [MaxLength(Common.Common.UserName_Name_Length)]
        public string Name { get; set; }

        [MaxLength(Common.Common.Second_Name_Length)]
        public string SecondName { get; set; }

        [Required]
        [MaxLength(Common.Common.Third_Name_Length)]
        public string ThirdName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        
        //Add continents

        [Required]
        public string PhoneNumber { get; set; }
        
        [Required]
        [ForeignKey(nameof(Accounts))]
        public int AccountId { get; set; }
        public Accounts Accounts { get; set; }

        public DateTime LastTimeLogin { get; set; }
    }
}
