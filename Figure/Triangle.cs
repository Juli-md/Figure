using System;

namespace Figure
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Figure
    {
        private double A { get; }
        private double B { get; }
        private double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= Eps || b <= Eps || c <= Eps)
            {
                throw new ArgumentOutOfRangeException("Стороны должны быть больше 0");
            }
            
            if (a - (b + c) > Eps || b - (a + c) > Eps || c - (a + b) > Eps)
            {
                throw new ArgumentException("Не соблюдается соотношение сторон треугольника");
            }
            
            A = a;
            B = b;
            C = c;
        }

        ///<inheritdoc/>
        public override double Area()
        {
            var p = Perimeter()/2;
            return Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }

        /// <summary>
        /// Длина окружности
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return A + B + C; 
        }

        /// <summary>
        /// Проверяет является ли прямоугольным
        /// </summary>
        public bool IsRightTriangle()
        {
            return 
                IsEqual(A * A,B * B + C * C) 
                || IsEqual(B * B, A * A + C * C)
                || IsEqual(C * C, B * B + A * A);
        }
        
        private bool IsEqual(double a, double b)
        {
            return Math.Abs(a - b) < Eps;

        }
    }
}