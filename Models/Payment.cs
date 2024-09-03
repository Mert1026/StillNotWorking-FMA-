using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Payment
    {
      [Key]
      [Required]
      public int id { get; set; }

      [Required]
      [ForeignKey(nameof(PaymentHistory))]
      public int PaymentHistoryId { get; set; }
      public PaymentHistory PaymentHistory { get; set; }

      [Required]
      [Range(Common.Common.Moneys_Min_Length, Common.Common.Moneys_Max_Length)]
      public decimal MoneySpend { get; set; }

      [Required]
      public DateTime PaymentDate { get; set; }

      [MaxLength(Common.Common.Interceptor_OR_CameFrom_Name_Length)]
      public string SpendTo { get; set; }
    }
}
