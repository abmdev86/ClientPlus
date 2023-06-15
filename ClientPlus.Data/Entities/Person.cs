using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPlus.Data.Entities
{
    public class Person : EntityBase
    {
        public string? FirstName { get; set; }

        public override string ToString() => $"ID: {Id}, Name: {FirstName}";
    }
}
