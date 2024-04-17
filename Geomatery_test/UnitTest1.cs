namespace Geomatery_test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    
    public void Areaofsquare()
    {
            isquare square = new isquare { SideLength = 5 };
            double area = square.CalculateArea();
            Assert.AreEqual(25, area);
    }
    [TestMethod]
        public void Area_Length10_Returns100()
        {
            // Arrange
            double sideLength = 10;
            isquare square = new isquare { SideLength = sideLength };

            // Act
            double area = square.CalculateArea();

            // Assert
            Assert.AreEqual(100, area);
        }
        [TestMethod]
        public void Area_Length0_Returns0()
        {
            // Arrange
            double sideLength = 0;
            isquare square = new isquare { SideLength = sideLength };

            // Act
            double area = square.CalculateArea();

            // Assert
            Assert.AreEqual(0, area);
        }
        // test cases for square perimeter
        [TestMethod]
        public void Perimeter_WithSideLength5_Returns20()
        {
            // Arrange
            isquare square = new isquare { SideLength = 5 };

            // Act
            double perimeter = square.CalculatePerimeter();

            // Assert
            Assert.AreEqual(20, perimeter);
        }
        [TestMethod]
        public void CalculatePerimeter_WithSideLength10_Returns40()
        {
            // Arrange
            isquare square = new isquare { SideLength = 10 };

            // Act
            double perimeter = square.CalculatePerimeter();

            // Assert
            Assert.AreEqual(40, perimeter);
        }
        [TestMethod]
        public void CalculatePerimeter_WithSideLength0_Returns0()
        {
            // Arrange
            isquare square = new isquare { SideLength = 0 };

            // Act
            double perimeter = square.CalculatePerimeter();

            // Assert
            Assert.AreEqual(0, perimeter);
        }
}