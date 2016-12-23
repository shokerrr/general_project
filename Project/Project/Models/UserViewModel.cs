using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain;

namespace Project.Models
{
    public class UserViewModel
    {

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string BankDetails { get; set; }

        public List<Order> HistoryOfOrders { get; set; }
        public List<Feedback> HistoryOfFeedbacks { get; set; }
        public List<Advertisment> HistoryOfAdvertisments { get; set; }

        public List<Rate> PerformerRating { get; set; }
        public List<Rate> CustomerRating { get; set; }    
    }
}