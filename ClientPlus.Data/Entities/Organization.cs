﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPlus.Data.Entities
{
    public class Organization : EntityBase
    {
        public string? Name { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
