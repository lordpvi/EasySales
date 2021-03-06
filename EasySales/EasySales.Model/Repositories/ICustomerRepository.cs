﻿using EasySales.Infrastructure.RepositoryFramework;
using EasySales.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySales.Model.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
    }
}
