using System;

namespace Figure
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Figure
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= Eps)
            {
                throw new ArgumentOutOfRangeException("Радиус должен быть больше 0");
            }
            Radius = radius;
        }

        ///<inheritdoc/>
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        ///<inheritdoc/>
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}