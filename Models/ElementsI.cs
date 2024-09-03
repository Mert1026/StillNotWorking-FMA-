using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ElementsI
    {
      [Key]
      [Required]
      public int id {  get; set; }

      [ForeignKey(nameof(Income))]
      [Required]
      public int IncomeId { get; set; }
      public Income Income { get; set; }

      [MaxLength(Common.Common.UserName_Name_Length)]
      [Required]
      public string Name { get; set; }

      [Required]
      [Range(Common.Common.Moneys_Min_Length, Common.Common.Moneys_Max_Length)]
      public string Price { get; set; }
    }
}
