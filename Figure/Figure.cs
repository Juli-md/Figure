namespace Figure
{
    /// <summary>
    /// Фигура
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Точность
        /// </summary>
        public const double Eps = 1e-8;
      
        /// <summary>
        /// Посчитать площадь
        /// </summary>
        public abstract double Area();
    
        /// <summary>
        /// Посчитать периметр
        /// </summary>
        public abstract double Perimeter();
    }
}