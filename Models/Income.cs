﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Income
    {
      [Key]
      [Required]
      public int id {  get; set; }

      [ForeignKey(nameof(IncomeHistory))]
      [Required]
      public int IncomeHistoryId { get; set; }  
      public IncomeHistory IncomeHistory { get; set; }

      [Required]
      [Range(Common.Common.Moneys_Min_Length, Common.Common.Moneys_Max_Length)]
      public decimal IncomeBalance {  get; set; }

      [Required]
      public DateTime IncomeDate { get; set; }

      [Required]
      [MaxLength(Common.Common.Interceptor_OR_CameFrom_Name_Length)]
      public string MoneySource { get; set; }
 

    }
}
