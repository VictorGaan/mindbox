using AreaCalculation.Interfaces;

namespace AreaCalculation.Figures
{
    /// <summary>
    ///     Круг.
    /// </summary>
    public class Circle : IShape
    {
        private readonly double _radius;

        /// <summary>
        ///     Конструктор.
        /// </summary>
        /// <param name="radius"> Радиус круга. </param>
        public Circle(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        ///     Получение площади круга.
        /// </summary>
        /// <returns> Площадь круга. </returns>
        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
