using BLL.DTO;

namespace BLL.Interfaces
{
    public interface IFeedback
    {
        void AddFeedback(FeedbackDTO feedbackDto);

        void Dispose();
    }
}
