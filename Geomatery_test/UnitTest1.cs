namespace Geomatery_test;

[TestClass]
public class UnitTest1
{
    // test cases for square area and length
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
           
            double sideLength = 10;
            isquare square = new isquare { SideLength = sideLength };
            double area = square.CalculateArea();
            Assert.AreEqual(100, area);
        }
        [TestMethod]
        public void Area_Length0_Returns0()
        {
           
            double sideLength = 0;
            isquare square = new isquare { SideLength = sideLength };
            double area = square.CalculateArea();
            Assert.AreEqual(0, area);
        }
        // test cases for square perimeter
        [TestMethod]
        public void Perimeter_WithSideLength5_Returns20()
        {
           
            isquare square = new isquare { SideLength = 5 };
            double perimeter = square.CalculatePerimeter();
            Assert.AreEqual(20, perimeter);
        }
        [TestMethod]
        public void Perimeter_WithSideLength10_Returns40()
        {
           
            isquare square = new isquare { SideLength = 10 };
            double perimeter = square.CalculatePerimeter();
            Assert.AreEqual(40, perimeter);
        }
        [TestMethod]
        public void Perimeter_WithSideLength0_Returns0()
        {
           
            isquare square = new isquare { SideLength = 0 };
            double perimeter = square.CalculatePerimeter();
            Assert.AreEqual(0, perimeter);
        }
        // test cases for triangle base height
        [TestMethod]
        public void Area_Base5Height4_Returns10()
        {
           
            itriangle triangle = new itriangle() { Base = 5, Height = 4 };
            double area = triangle.CalculateArea();
            Assert.AreEqual(10, area);
        }
        
         [TestMethod]
        public void Area_Base10Height3_Returns15()
        {
          
            itriangle triangle = new itriangle() { Base = 10, Height = 3 };
            double area = triangle.CalculateArea();
            Assert.AreEqual(15, area);
        }
         [TestMethod]
        public void Area_Base8Height8_Returns32()
        {
            itriangle triangle = new itriangle() { Base = 8, Height = 8 };
            double area = triangle.CalculateArea();
            Assert.AreEqual(32, area);
        }

        // test cases for perimeter of triangle.
          [TestMethod]
        public void Perimeter_EquilateralTriangleWithSideLength3_Returns9()
        {
            double baseLength = 3;
            itriangle triangle = new itriangle { Base = baseLength };
            double result = triangle.CalculatePerimeter();
            Assert.AreEqual(9, result);
        }
        
        [TestMethod]
        public void Perimeter_EquilateralTriangleWithSideLength5_Returns15()
        {
           
            double baseLength = 5;
            itriangle triangle = new itriangle { Base = baseLength };
            double result = triangle.CalculatePerimeter();
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Perimeter_EquilateralTriangleWithSideLength10_Returns30()
        {
           
            double baseLength = 10;
            itriangle triangle = new itriangle { Base = baseLength };
            double result = triangle.CalculatePerimeter();
            Assert.AreEqual(30, result);
        }

        // test cases for rectangle 
        [TestMethod]
        public void Area_Length5Width3_Returns15()
        {
            irectangle rectangle = new irectangle(5, 3);
            double area = rectangle.CalculateArea();
            Assert.AreEqual(15, area);
        }
         [TestMethod]
        public void Area_Length0Width10_Returns0()
        {
            irectangle rectangle = new irectangle(0, 10);
            double area = rectangle.CalculateArea();
            Assert.AreEqual(0, area);
        }
        [TestMethod]
        public void Area_Length7Width7_Returns49()
        {
            irectangle rectangle = new irectangle(7, 7);
            double area = rectangle.CalculateArea();
            Assert.AreEqual(49, area);
        }
        // test cases for rectangle perimeter
        [TestMethod]
        public void Perimeter_Length5Width3_Returns16()
        {
          
            double length = 5;
            double width = 3;
            irectangle rectangle = new irectangle(length, width);
            double perimeter = rectangle.CalculatePerimeter();
            Assert.AreEqual(16, perimeter);
        }
        
    [TestMethod]
    public void Perimeter_Length10Width10_Returns40()
    {
       
        double length = 10;
        double width = 10;
        irectangle rectangle = new irectangle(length, width);
        double perimeter = rectangle.CalculatePerimeter();
        Assert.AreEqual(40, perimeter);
    }
    [TestMethod]
    public void Perimeter_Length0Width0_Returns0()
    {
       
        double length = 0;
        double width = 0;
        irectangle rectangle = new irectangle(length, width);
        double perimeter = rectangle.CalculatePerimeter();
        Assert.AreEqual(0, perimeter);
    }



}