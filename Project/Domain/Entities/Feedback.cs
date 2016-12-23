using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    //  Отзывы
    public class Feedback: EntityBase
    {
        [Required]
        public Advertisment Service { get; set; }
        [Required]
        public User Author { get; set; }
        [Required]
        public string Text { get; set; }
        public Rate Mark { get; set; }
    }
}
