using Domain;

namespace BLL.DTO
{
    public class FeedbackDTO: EntityBase
    {
        public Advertisment Service { get; set; }
        public User Author { get; set; }
        public string Text { get; set; }
        public Rate Mark { get; set; }
    }
}
