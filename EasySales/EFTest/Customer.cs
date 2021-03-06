﻿using EasySales.Infrastructure.DomainBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest
{
    public class Customer : EntityBase
    {
        public override int Id { get; set; }
        public override Guid Key { get; set; }
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
    }
}
