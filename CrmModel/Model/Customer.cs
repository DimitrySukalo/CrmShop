﻿using System.Collections.Generic;

namespace CrmModel.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Check> Checks { get; set; } 

        public override string ToString()
        {
            return Name;
        }
    }
}
