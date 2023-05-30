using AreaCalculation.Interfaces;

namespace AreaCalculation.Figures
{
    /// <summary>
    ///     Треугольник.
    /// </summary>
    public class Triangle : IShape
    {
        private readonly double _a, _b, _c;

        /// <summary>
        ///     Конструктор.
        /// </summary>
        /// <param name="a"> Сторона А. </param>
        /// <param name="b"> Сторона B. </param>
        /// <param name="c"> Сторона C. </param>
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        
        /// <summary>
        ///     Получение площади треугольника.
        /// </summary>
        /// <returns> Площадь треугольника. </returns>
        /// <exception cref="InvalidOperationException"> Исключение в случае, если треугольник не является прямоугольным. </exception>
        public double GetArea()
        {
            if (!IsRightAngled())
                throw new InvalidOperationException();

            var p = GetPerimeter();

            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }


        /// <summary>
        ///     Получение периметра треугольника.
        /// </summary>
        /// <returns> Периметр треугольника. </returns>
        private double GetPerimeter() => (_a + _b + _c) / 2.0;

        /// <summary>
        ///     Является ли треугольник, прямоугольным.
        /// </summary>
        /// <returns> True, если является, иначе False. </returns>
        public bool IsRightAngled() => (_a * _a + _b * _b == _c * _c) || (_a * _a + _c * _c == _b * _b) || (_c * _c + _b * _b == _a * _a);
    }
}
