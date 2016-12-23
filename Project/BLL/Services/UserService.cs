using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.DTO;
using BLL.Infrastructure;
using Domain;
using System.Data.Entity;
using Repository;

//using AutoMapper;

namespace BLL.Services
{
    public class UserService: IUserService //DomainService
    {
        IUnitOfWork Database { get; set; }

        public UserService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void AddUser(UserDTO userDto)
        {
            User user = new User
            {
                FirstName = userDto.FirstName,
                MiddleName = userDto.MiddleName,
                LastName = userDto.LastName
            };

            Database.User.Create(user);
            //Database.Save();
            Database.Commit();
        }

        //public void DeleteUser(UserDTO userDto)
        //{
        //    User user = Database.User.Find(userDto)
        //    //{
        //     //   FirstName = userDto.FirstName,
        //     //   MiddleName = userDto.MiddleName,
        //     //   LastName = userDto.LastName
        //    //};
        //    if (user != null)
        //    Database.User.De(user);
        //    //Database.Save();
        //    //Database.Commit();
        //}

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
