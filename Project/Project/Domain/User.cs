using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User: EntityBase
    {
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LasName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string BankDetails { get; set; }

        public List<Order> HistoryOfOrders { get; set; }
        public List<Feedback> HistoryOfFeedbacks { get; set; }
        public List<Advertisment> HistoryOfAdvertisments { get; set; }

        public List<Rate> PerformerRating { get; set; }
        public List<Rate> CustomerRating { get; set; }

    }
}
