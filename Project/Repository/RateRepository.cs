﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repository
{
    public class RateRepository: RepositoryBase<Rate>, IRateRepository
    {
        public RateRepository(ServiceContext context): base(context)
        {

        }
    }
}
