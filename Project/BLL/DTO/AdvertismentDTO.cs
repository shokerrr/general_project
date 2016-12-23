using System.Collections.Generic;
using Domain;

namespace BLL.DTO
{
    public class AdvertismentDTO: EntityBase
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
