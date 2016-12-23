using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain;

namespace Project.Models
{
    public class AdvertismentViewModel
    {
        public enum Type { Performer, Customer }
        public Type TypeOfAuthor { get; set; }
        public User Author { get; set; }
        public Category ServiceCategory { get; set; }
        public string Text { get; set; }
        public float Cost { get; set; }
        public List<Feedback> HistoryOfFeedbacks { get; set; }
    }
}