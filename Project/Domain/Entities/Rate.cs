using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    //  Оценки
    public class Rate: EntityBase
    {
        [Required]
        public Category CategoryRate { get; set; }
        public decimal Rating { get; set; }
    }
}
