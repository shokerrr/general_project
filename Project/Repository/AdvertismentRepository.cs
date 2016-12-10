using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AdvertismentRepository: RepositoryBase<Advertisment>, IAdvertismentRepository
    {
        public AdvertismentRepository(ServiceContext context): base(context)
        {

        }
    }
}
