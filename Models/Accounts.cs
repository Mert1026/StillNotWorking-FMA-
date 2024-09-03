using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Accounts 
    {
      [Key]
      [Required]
      public int id {  get; set; }

      [Required]
      [MaxLength(Common.Common.UserName_Name_Length)]
      public string Name { get; set; }

      [Required]
      public string PhoneNumber { get; set; }
      [Required]
      [Range(Common.Common.Moneys_Min_Length, Common.Common.Moneys_Max_Length_Acc_Full_Balance)]
      public decimal Ballance { get; set; }
    
      
      [Range(Common.Common.Moneys_Min_Length, Common.Common.Moneys_Max_Length)]
      public decimal MonthlyIncome { get; set; }

      public DateTime LastTimeLogin { get; set; }


    }
}
