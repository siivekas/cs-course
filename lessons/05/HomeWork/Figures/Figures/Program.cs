using System;
using System.Globalization;

namespace Figures
{
    class Program
    {
        private const int TryNum = 3;

        static void Main(string[] args)
        {
            Console.WriteLine("Choose a figure:");
            foreach (FigureTypes type in Enum.GetValues(typeof(FigureTypes)))
            {
                Console.WriteLine($"{(int) type} - {type}");
            }

            int chooseFigure = TryNum;
            while (chooseFigure > 0)
            {
                try
                {
                    int userInput = int.Parse(Console.ReadLine());
                    FigureTypes typeSelected = (FigureTypes) userInput;

                    if (!Enum.IsDefined(typeof(FigureTypes), userInput))
                        throw new ArgumentException();

                    int enterLeft = TryNum;
                    while (enterLeft > 0)
                    {
                        try
                        {
                            switch (typeSelected)
                            {
                                case FigureTypes.Circle:
                                    Console.WriteLine("Enter diameter:");
                                    double circleD = StringToDouble(Console.ReadLine());

                                    Console.WriteLine($"Area of the circle is {0.25 * Math.PI * circleD}");
                                    Console.WriteLine($"Circumference of the circle is {Math.PI * circleD}");
                                    break;
                                case FigureTypes.Triangle:
                                    Console.WriteLine("Enter side length:");
                                    double triangleA = StringToDouble(Console.ReadLine());
                                    Console.WriteLine("Enter the second side length:");
                                    double triangleB = StringToDouble(Console.ReadLine());
                                    Console.WriteLine("Enter the third side length:");
                                    double triangleC = StringToDouble(Console.ReadLine());

                                    double halfP = (triangleA + triangleB + triangleC) / 2.0;
                                    Console.WriteLine(
                                        $"Area of the triangle is {Math.Sqrt(halfP * (halfP - triangleA) * (halfP - triangleB) * (halfP - triangleC))}");
                                    Console.WriteLine($"Perimeter is {halfP * 2}");
                                    break;
                                case FigureTypes.Rectangle:
                                    Console.WriteLine("Enter side length:");
                                    double rectangleA = StringToDouble(Console.ReadLine());
                                    Console.WriteLine("Enter the second side length:");
                                    double rectangleB = StringToDouble(Console.ReadLine());

                                    Console.WriteLine($"Area of the rectangle is {rectangleA * rectangleB}");
                                    Console.WriteLine($"Perimeter is {2 * (rectangleA + rectangleB)}");
                                    break;
                            }
                            enterLeft = 0;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine($"Invalid input, tries left: {enterLeft - 1}");
                        }
                        catch (Exception e) // like "default" in switch construction
                        {
                            Console.WriteLine($"Unexpected error: {e.Message}");
                        }

                        enterLeft--;
                    }

                    chooseFigure = 0;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine($"Nothing was chosen, tries left: {chooseFigure - 1}");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"No type found, tries left: {chooseFigure - 1}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Invalid input, tries left: {chooseFigure - 1}");
                }
                catch (Exception e) // like "default" in switch construction
                {
                    Console.WriteLine($"Unexpected error: {e.Message}");
                }

                chooseFigure--;
            }
        }

        static double StringToDouble(string toParse)
        {
            try
            {
                return double.Parse(toParse.Replace(",", "."), CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                throw new FormatException();
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException();
            }
        }
    }
}