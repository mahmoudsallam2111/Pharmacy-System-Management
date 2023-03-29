using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_System.Entities
{
    internal class Medicine
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int Bprice { get; set; }
        public int Sprice { get; set; }
        public int Quantity{ get; set; }
        public DateTime Expdate { get; set; }
        public string? Company { get; set; }
    }
}
