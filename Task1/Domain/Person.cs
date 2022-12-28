﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person : Object
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }


        public override string ToString()
        {
            return $"Hello! My name is {Name}";
        }

    }
}
