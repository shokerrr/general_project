using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Advertisment: EntityBase
    {
        public enum Type { Performer, Customer }

        [Required]
        public Type TypeOfAuthor { get; set; }
        [Required]
        public User Author { get; set; }
        [Required]
        public Category ServiceCategory { get; set; }
        [Required]
        public string Text { get; set; }
        public float Cost { get; set; }
        public List<Feedback> HistoryOfFeedbacks { get; set; }
    }
}
