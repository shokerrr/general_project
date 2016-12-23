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
    public class AdvertismentService: IAdvertisment
    {
        IUnitOfWork Database { get; set; }

        public  AdvertismentService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void AddAdvertisment(AdvertismentDTO advertismentDto)
        {
            Advertisment advertisment = new Advertisment
            {
                TypeOfAuthor = (Advertisment.Type) advertismentDto.TypeOfAuthor,
                Author = advertismentDto.Author,
                Text = advertismentDto.Text,
                Cost = advertismentDto.Cost,
                HistoryOfFeedbacks = advertismentDto.HistoryOfFeedbacks,
                ServiceCategory = advertismentDto.ServiceCategory
            };

            Database.Advertisment.Create(advertisment);
            Database.Save();
        }

        public void UpdateAdvertisment(AdvertismentDTO advertismentDto)
        {
            Advertisment advertisment = new Advertisment
            {
                TypeOfAuthor = (Advertisment.Type)advertismentDto.TypeOfAuthor,
                Author = advertismentDto.Author,
                Text = advertismentDto.Text,
                Cost = advertismentDto.Cost,
                HistoryOfFeedbacks = advertismentDto.HistoryOfFeedbacks,
                ServiceCategory = advertismentDto.ServiceCategory
            };

            Database.Advertisment.Update(advertisment);
            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }


    }
}
