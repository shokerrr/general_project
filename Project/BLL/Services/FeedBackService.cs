using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using Domain;
using Repository;

namespace BLL.Services
{
    public class FeedbackService: IFeedback
    {
        IUnitOfWork Database { get; set; }

        public FeedbackService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void AddFeedback(FeedbackDTO feedBackDto)
        {
            Feedback feedback = new Feedback
            {
                Service = feedBackDto.Service,
                Author = feedBackDto.Author,
                Text = feedBackDto.Text,
                Mark = feedBackDto.Mark
            };

            Database.Feedback.Create(feedback);
            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }

}
