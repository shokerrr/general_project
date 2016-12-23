using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using BLL.DTO;

namespace BLL.Interfaces
{
    public interface IAdvertisment
    {
        void AddAdvertisment(AdvertismentDTO advertismentDto);
        void UpdateAdvertisment(AdvertismentDTO advertismentDto);
        void Dispose();
    }
}
