using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PaymentHistory
    {
        [Key]
        [Required]
        public int id {  get; set; }

        [Required]
        [ForeignKey(nameof(Accounts))]
        public int AccountId { get; set; }
        public Accounts Accounts { get; set; }

        [MaxLength(Common.Common.Title_Max_Length)]
        public string Title { get; set; }
    }
}
                                                                                                                                                                                                                                                               