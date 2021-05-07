using System;
using Figure;
using Xunit;

namespace FigureTests
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_NotValid_Triangle_1()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 5));
        }
        
        [Fact]
        public void Triangle_NotValid_Triangle_2()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(2, 5, 1));
        }
        
        [Fact]
        public void Triangle_NotValid_Triangle_3()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(5, 1, 2));
        }
        
        [Fact]
        public void Triangle_NotValid_Triangle_LessZero1()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 3, 4));
        }
        
        [Fact]
        public void Triangle_NotValid_Triangle_LessZero2()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3, -1, 4));
        }
        
        [Fact]
        public void Triangle_NotValid_Triangle_LessZero3()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(4, 3, -1));
        }
        
        [Fact]
        public void Triangle_NotValid_Triangle_LessProximity1()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1e-9, 3, 4));
        }
        
        [Fact]
        public void Triangle_NotValid_Triangle_LessProximity2()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3, 1e-9, 4));
        }
        
        [Fact]
        public void Triangle_NotValid_Triangle_LessProximity3()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(4, 3, 1e-9));
        }
        
        [Fact]
        public void Triangle_NotValid_Triangle_ValidArea()
        {
            var figure = new Triangle(3, 4, 5);
            Assert.True(Math.Abs(figure.Area() - 6) < Figure.Figure.Eps);
        }
        
        [Fact]
        public void Triangle_NotValid_Triangle_ValidPerimeter()
        {
            var figure = new Triangle(3, 4, 5);
            Assert.True(Math.Abs(figure.Perimeter() - 12) < Figure.Figure.Eps);
        }
        
        [Fact]
        public void Triangle_NotValid_Triangle_ValidIsRightTriangle()
        {
            var figure = new Triangle(3, 4, 5);
            Assert.True(figure.IsRightTriangle());
        }
    }
}