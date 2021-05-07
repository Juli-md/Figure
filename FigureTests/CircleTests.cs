using System;
using Figure;
using Xunit;

namespace FigureTests
{
    public class CircleTests
    {
        [Fact]
        public void Circle_NotValid_Radius_Zero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
        }
        
        [Fact]
        public void Circle_NotValid_Radius_LessZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
        }
        
        [Fact]
        public void Circle_NotValid_Radius_LessProximity()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(1e-9));
        }
        
        [Fact]
        public void Circle_NotValid_Radius_Valid_Area()
        {
            var figure = new Circle(2);
            Assert.True(Math.Abs(figure.Area() - 4*Math.PI) < Figure.Figure.Eps);
            Assert.True(Math.Abs(figure.Perimeter() - 4*Math.PI) < Figure.Figure.Eps);
        }
    }
}