﻿using EasySales.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySales.Infrastructure.Repositories.Customers
{
    public class StudentGroupRepository : EFSqlCeRepositoryBase<StudentGroup>, IStudentGroupRepository
    {
        public StudentGroupRepository() : base() { }
    }
}
