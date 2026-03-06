using GeometryShape;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapeTests
{
    public class ShapeTest
    {
        [Fact]
        public void CreateRectangle_ReturnMessage()
        {
            var actualMess = "Прямоугольник: ширина-1,2, длина-2";

            Rectangle rectangle = new Rectangle(1.2, 2.0);

            string message = rectangle.ToString();

            Assert.Equal(message, actualMess);
        }

        [Fact]
        public void CreateTriangle_ReturnMessage()
        {
            var actualMess = "Треугольник: сторона A-3, сторона B-5, сторона C-4";

            Triangle triangle = new Triangle(3, 5, 4);

            string message = triangle.ToString();

            Assert.Equal(message, actualMess);
        }

        [Theory]
        [InlineData(1.41, 4.75, 6.6975)]
        [InlineData(5, 8, 40)]
        [InlineData(13, 34, 442)]
        public void AreaRectangle_WidthHeight_ActualArea_ReturnMessage(double a, double b, double area)
        {
            var actualArea = area;

            Rectangle rectangle = new Rectangle(a, b);

            Assert.Equal(rectangle.Area(), actualArea);
        }

        [Theory]
        [InlineData(1.41, 4.75, 12.32)]
        [InlineData(5, 8, 26)]
        [InlineData(13, 34, 94)]
        public void PerimeterRectangle_WidthHeight_ActualPerimeter_ReturnMessage(double a, double b, double area)
        {
            var actualArea = area;

            Rectangle rectangle = new Rectangle(a, b);

            Assert.Equal(rectangle.Perimeter(), actualArea);
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 5, 6, 12)]
        public void AreaTriangle_ABC_ActualArea_ReturnMessage(double a, double b, double c, double area)
        {
            var actualArea = area;

            Triangle triangle = new Triangle(a, b, c);

            Assert.Equal(triangle.Area(), actualArea);
        }

        [Theory]
        [InlineData(3.5, 4.7, 2.8, 11)]
        [InlineData(5, 8, 7, 20)]
        [InlineData(35, 34, 40, 109)]
        public void PerimeterTriangle_ABC_ActualPerimeter_ReturnMessage(double a, double b, double c, double perimeter)
        {
            var actualPerimeter = perimeter;

            Triangle triangle = new Triangle(a, b, c);

            Assert.Equal(triangle.Perimeter(), actualPerimeter);
        }

        [Theory]
        [InlineData(-59.0)]
        [InlineData(0.0)]
        public void CreateRectangle_WidthIncorrectData_ReturnMessage(double data)
        {
            var actualMess = "Входимые данные меньше или равны 0";

            Rectangle rectangle;

            var exception = Assert.Throws<ArgumentException>(() => rectangle = new Rectangle(data, 12.0));

            Assert.Equal(exception.Message, actualMess);
        }

        [Theory]
        [InlineData(-100.0)]
        [InlineData(0.0)]
        public void CreateTriangle_WidthIncorrectData_ReturnMessage(double data)
        {
            var actualMess = "Входимые данные меньше или равны 0";

            Triangle triangle;

            var exception = Assert.Throws<ArgumentException>(() => triangle = new Triangle(data, 5, 4));

            Assert.Equal(exception.Message, actualMess);
        }

        [Theory]
        [InlineData(1, 5, 3)]
        [InlineData(6, 7.5, 20)]
        [InlineData(130, 1.5, 6.4)]
        public void CreateTriangle_WidthIncorrectTriangle_ReturnMessage(double a, double b, double c)
        {
            var actualMess = "Сумма 2 сторон меньше оставшейся";

            Triangle triangle;

            var exception = Assert.Throws<Exception>(() => triangle = new Triangle(a, b, c));

            Assert.Equal(exception.Message, actualMess);
        }
    }
}

