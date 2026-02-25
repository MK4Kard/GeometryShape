using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Triangle : Shape
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Входимые данные меньше или равны 0");
            }

            if ((sideA + sideB) < sideC || (sideC + sideB) < sideA || (sideA + sideC) < sideB)
            {
                throw new Exception("Сумма 2 сторон меньше оставшейся");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double Area()
        {
            double p = (SideA + SideB + SideC) / 2;

            double s = p * (p - SideA) * (p - SideB) * (p - SideC);

            double result = Math.Sqrt(s);

            return result;
        }

        public override double Perimeter()
        {
            double result = SideA + SideB + SideC;

            return result;
        }

        public override string ToString()
        {
            return $"Треугольник: сторона A-{SideA}, сторона B-{SideB}, сторона C-{SideC}";
        }
    }
}
