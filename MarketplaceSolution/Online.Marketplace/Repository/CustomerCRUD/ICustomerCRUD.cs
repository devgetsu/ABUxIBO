﻿using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;
using System.Runtime.InteropServices;
namespace Online.Marketplace.Repository.CustomerCRUD
{
    public interface ICustomerCRUD
    {
        public string Create(Customers customer);
        public IEnumerable<Customers> GetAll();
        public Customers GetByID(int id);
        public string DeleteByID(int id);
        public Customers Update(int id, CustomersDTO product);
    }
}
