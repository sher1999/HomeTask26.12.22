using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class Circle : Shape
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double Area()
        {
            return 2*_radius;
        }
        public override double Perimeter()
        {
            return 3.14*_radius*_radius;
        }
    }
}
