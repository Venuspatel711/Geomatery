using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using System.Threading.Tasks;
using System.Drawing;


var featureManagement = new Dictionary<string, string> {{ "FeatureManagement:Square", "true"}, { "FeatureManagement:Rectangle", "false"}, { "FeatureManagement:Triangle", "true"}};

            IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

            var services = new ServiceCollection();
            services.AddFeatureManagement(configuration);
            var serviceProvider = services.BuildServiceProvider();
            var featureManager = serviceProvider.GetService<IFeatureManager>();

            if (await featureManager.IsEnabledAsync("Square"))
            {
                // Provide access to Square

                Console.WriteLine("Enter the side length of the square:");
                double sideLength = double.Parse(Console.ReadLine());

                var square = new isquare { SideLength = sideLength };

                Console.WriteLine($"Square Area: {square.CalculateArea()}");
                Console.WriteLine($"Square Perimeter: {square.CalculatePerimeter()}");        
             }
            else
            {
                Console.WriteLine("Square feature is not enabled.");
            }


            if (await featureManager.IsEnabledAsync("rectangle"))
            {
                
                Console.WriteLine("Enter the length of the rectangle:");
                var Length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width of the rectangle:");
                var Width = double.Parse(Console.ReadLine());


                irectangle rectangle = new irectangle( Length,  Width);

                Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
                Console.WriteLine($"Rectangle Perimeter: {rectangle.CalculatePerimeter()}");
             }
            else
            {
                Console.WriteLine("rectangle feature is not enabled.");
            }
            if (await featureManager.IsEnabledAsync("triangle"))
            {
                Console.WriteLine("Enter the base of the triangle:");
                double baseLength = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of the triangle:");
                double height = double.Parse(Console.ReadLine());
                var triangle = new itriangle { Base = baseLength, Height = height };
                Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}, Perimeter: {triangle.CalculatePerimeter()}");}
            else
            {
                Console.WriteLine("triangle feature is not enabled.");
            }