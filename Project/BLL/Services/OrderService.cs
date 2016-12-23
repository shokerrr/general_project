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
    public class OrderService:  IOrderService
    {
        IUnitOfWork Database { get; set; }

        public OrderService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public IEnumerable<OrderDTO> GetOrder()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            Mapper.Initialize(cfg => cfg.CreateMap<Order, OrderDTO>());
            return Mapper.Map<IEnumerable<Order>, List<OrderDTO>>(Database.Order.GetAll());
        }

        public void AddOrder(OrderDTO orderDto)
        {
            Order order = new Order
            {
                Client = orderDto.Client,
                Service = orderDto.Service,
                Date = orderDto.Date
            };

            Database.Order.Create(order);
            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
