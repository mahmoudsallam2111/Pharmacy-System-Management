using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_System.Entities
{
    
    internal class Emloyee
    {
        [Key]
        public int  Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public int salary { get; set; }
        public int Age { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string Role { get; set; }    


    }
}
