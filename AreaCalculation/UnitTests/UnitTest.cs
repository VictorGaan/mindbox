using AreaCalculation.Figures;
using FluentAssertions;

namespace UnitTests
{
    public class Tests
    {

        #region Circle
        [Test]
        public void GetArea_10Radius_ExpectedArea314()
        {
            //Arrange
            var circle = new Circle(10);
            var expectedArea = 314.1592653589793;

            //Act
            var area = circle.GetArea();

            //Assert
            area.Should().Be(expectedArea);
        }
        #endregion

        #region Triangle
        [Test]
        public void GetArea_TriangleIsNotRightAngled_ExpectedException()
        {
            //Arrange
            var triangle = new Triangle(5, 4, 3);

            //Act
            var area = triangle.GetArea();

            //Assert

            area.Should().As<InvalidOperationException>();
        }

        [Test]
        public void GetArea_Triangle2and3and4_Expected10()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var area = triangle.GetArea();

            //Assert

            area.Should().Be(6);
        }
        #endregion
    }
}