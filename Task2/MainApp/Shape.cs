using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class Shape : Object
    {
        public Location c;

        public override string ToString()
        {
            return "Hello";
        }
        public virtual double Area()
        {
            return 5;
        }
        public virtual double Perimeter()
        {
            return 10;
        }

    }
}
