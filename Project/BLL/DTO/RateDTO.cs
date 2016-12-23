using Domain;

namespace BLL.DTO
{
    public class RateDTO: EntityBase
    {
        public Category CategoryRate { get; set; }
        public decimal Rating { get; set; }
    }
}
