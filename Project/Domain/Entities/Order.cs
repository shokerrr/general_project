using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order: EntityBase
    {
        [Required]
        public User Client { get; set; }
        [Required]
        public Advertisment Service { get; set; }
        public DateTime Date { get; set; }

    }
}
