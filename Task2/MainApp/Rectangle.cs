using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public  class Rectangle : Shape
    {
        private double _side1;
        private double _side2;
        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }
        public override double Area()
        {
            return _side1 * _side2;
        }
        public override double Perimeter()
        {
            return 2*(_side1 + _side2);
        }
    }
}
