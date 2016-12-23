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
    public class RateService: IRate
    {
               IUnitOfWork Database { get; set; }

        public RateService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void AddRate(RateDTO rateDto)
        {
            Rate rate = new Rate
            {
                CategoryRate = rateDto.CategoryRate,
                Rating = rateDto.Rating
            };

            Database.Rate.Create(rate);
            Database.Save();
        }

        public void UpdateRate(RateDTO rateDto)
        {
            Rate rate = new Rate
            {
                CategoryRate = rateDto.CategoryRate,
                Rating = rateDto.Rating
            };

            Database.Rate.Update(rate);
            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
