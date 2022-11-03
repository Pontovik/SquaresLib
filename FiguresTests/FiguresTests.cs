using SquaresLib;

namespace Figures.Tests
{
    public class CircleTests
    {
        [Fact]
        public void GetSquares_3_28returned()
        {
            //Given
            var circle = new Circle(3); 
            double rad = 3;
            //When
            double actual = circle.GetSquare();
            double expected = Math.Pow(rad, 2) * Math.PI;
            //Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Circle_RadiusIsNotPositive_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }
    }

    public class TriangleTests
    {
        [Fact]
        public void GetSquares_3_4_5_6returned()
        {
            //Given
            var triangle = new Triangle(3, 4, 5);
            //When
            double actual = triangle.GetSquare();
            double expected = 6.0;
            //Then
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,0,2)]
        [InlineData(0,1,2)]
        [InlineData(3,2,0)]
        public void Triangle_SidesEqualOrLessThan0_ThrowArgumentException(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Fact]
        public void Triangle_OneSideIsTooBig_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(2, 10, 1));
        }

        [Fact]
        public void Triangle_3_4_5_IsRectang()
        {
            //Given
            Triangle triangle = new Triangle(3, 4, 5);
            //When
            bool expected = true;
            bool actual = triangle.IsRectang();
            //Then
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Triangle_3_6_8_IsNotRectang()
        {
            //Given
            Triangle triangle = new Triangle(5, 6, 8);
            //When
            bool expected = false;
            bool actual = triangle.IsRectang();
            //Then
            Assert.Equal(expected, actual);
        }
    }
}