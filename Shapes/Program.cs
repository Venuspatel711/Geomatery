using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var featureManagement = new Dictionary<string, string>
            {
                { "FeatureManagement:Square", "true" },
                { "FeatureManagement:Rectangle", "true" },
                { "FeatureManagement:Triangle", "true" }
            };

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(featureManagement)
                .Build();

            bool isSquareFeatureEnabled = configuration["FeatureManagement:Square"].ToLower() == "true";
            bool isRectangleFeatureEnabled = configuration["FeatureManagement:Rectangle"].ToLower() == "true";
            bool isTriangleFeatureEnabled = configuration["FeatureManagement:Triangle"].ToLower() == "true";

            var services = new ServiceCollection();
            services.AddFeatureManagement(configuration);
            var serviceProvider = services.BuildServiceProvider();
            var featureManager = serviceProvider.GetService<IFeatureManager>();

            Console.WriteLine("Enter the side length of the square:");
            string squareSideLengthInput = Console.ReadLine();
            double squareSideLength = double.Parse(squareSideLengthInput);

            Console.WriteLine("Enter the length of the rectangle:");
            string rectangleLengthInput = Console.ReadLine();
            double rectangleLength = double.Parse(rectangleLengthInput);

            Console.WriteLine("Enter the width of the rectangle:");
            string rectangleWidthInput = Console.ReadLine();
            double rectangleWidth = double.Parse(rectangleWidthInput);

            Console.WriteLine("Enter the base of the triangle:");
            string triangleBaseInput = Console.ReadLine();
            double triangleBase = double.Parse(triangleBaseInput);

            Console.WriteLine("Enter the height of the triangle:");
            string triangleHeightInput = Console.ReadLine();
            double triangleHeight = double.Parse(triangleHeightInput);

           isquare square = new isquare { SideLength = squareSideLength };
            irectangle rectangle = new irectangle { Length = rectangleLength, Width = rectangleWidth };
            itriangle triangle = new itriangle { Base = triangleBase, Height = triangleHeight };

            if (isSquareFeatureEnabled)
            {
                Console.WriteLine($"Square Area: {square.CalculateArea()}, Perimeter: {square.CalculatePerimeter()}");
            }

            if (isRectangleFeatureEnabled)
            {
                Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.CalculatePerimeter()}");
            }

            if (isTriangleFeatureEnabled)
            {
                Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}, Perimeter: {triangle.CalculatePerimeter()}");
            }
        }
    }
}