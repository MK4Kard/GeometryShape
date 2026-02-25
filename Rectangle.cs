using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Rectangle : Shape
    {
        private double Width { get; set; }
        private double Height { get; set; }

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Входимые данные меньше или равны 0");
            }
            
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            double result = Width * Height;

            return result;
        }

        public override double Perimeter()
        {
            double result = 2 * (Width + Height);

            return result;
        }

        public override string ToString()
        {
            return $"Прямоугольник: ширина-{Width}, длина-{Height}";
        }
    }
}
