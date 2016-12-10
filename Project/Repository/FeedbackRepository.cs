using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repository
{
    public class FeedbackRepository : RepositoryBase<Feedback>, ICategoryRepository
    {
        public FeedbackRepository(ServiceContext context): base(context)
        {

        }
    }
}
