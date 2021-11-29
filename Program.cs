using System;
using Figures.Shapes;
using Figures.Styles;
using Figures.Shapes.Lines;
using size = Figures.Shapes.Shape.Size;
using color = System.ConsoleColor;
using arrowdirection = Figures.Shapes.Lines.Arrow.ArrowDirection;
using Figures.Shapes.Rectangles;
using System.Collections.Generic;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
            begin_again:
                Console.WriteLine("Choose shape from list below to print");
                Console.WriteLine(" exit-to exit application");
                Console.WriteLine(" 1-Triangle");
                Console.WriteLine(" 2-Recangle");
                Console.WriteLine(" 3-Square");
                Console.WriteLine(" 4-Line");
                Console.WriteLine(" 5-Arrow");
                Console.WriteLine(" 6-Doble Arrow");
                string exit = Console.ReadLine();
                if (exit.ToLower() == "exit") return;
                bool isParsed = int.TryParse(exit, out int shapeId);
                if (!isParsed || !(0 < shapeId && shapeId < 7))
                {
                    Console.WriteLine("You have chosen incorrect shape number, please try again or type exit to exit.");
                    goto begin_again;
                }
            begin_size_choose:
                Console.WriteLine("Choose shape size from list below");
                Console.WriteLine(" exit-to exit application");
                Console.WriteLine($"{(int)size.Small}-{size.Small}");
                Console.WriteLine($"{(int)size.Medium}-{size.Medium}");
                Console.WriteLine($"{(int)size.Big}-{size.Big}");
                exit = Console.ReadLine();
                if (exit.ToLower() == "exit") return;
                isParsed = int.TryParse(exit, out int shapeSizeInt);
                size shapeSize;
                if (isParsed && Enum.IsDefined(typeof(size), shapeSizeInt))
                {
                    shapeSize = (size)(shapeSizeInt);
                }
                else
                {
                    Console.WriteLine("You have chosen incorrect shape size, please try again or type exit to exit.");
                    goto begin_size_choose;
                }

            begin_color_choose:
                Console.WriteLine("Choose shape size from list below");
                Console.WriteLine(" exit-to exit application");
                Console.WriteLine(@"                                    Black = 0,
                                    DarkBlue = 1,
                                    DarkGreen = 2,
                                    DarkCyan = 3,
                                    DarkRed = 4,
                                    DarkMagenta = 5,
                                    DarkYellow = 6,
                                    Gray = 7,
                                    DarkGray = 8,
                                    Blue = 9,
                                    Green = 10,
                                    Cyan = 11,
                                    Red = 12,
                                    Magenta = 13,
                                    Yellow = 14,
                                    White = 15");
                color color;
                exit = Console.ReadLine();
                if (exit.ToLower() == "exit") return;
                isParsed = int.TryParse(exit, out int colorNumber);
                if (isParsed && Enum.IsDefined(typeof(color), colorNumber))
                {
                    color = (color)(colorNumber);
                }
                else
                {
                    Console.WriteLine("You have chosen incorrect color number, please try again or type exit to exit.");
                    goto begin_color_choose;
                }
            begin_style_choose:
                Console.WriteLine("Choose shape size from list below");
                Console.WriteLine(" exit-to exit application");
                Console.WriteLine($"1-Hash Style");
                Console.WriteLine($"2-Snow Style");
                Console.WriteLine($"3-Smiley Style");
                exit = Console.ReadLine();
                if (exit.ToLower() == "exit") return;
                isParsed = int.TryParse(exit, out int styleNumber);
                IStyle tmpStyle = new HashStyle(color);
                Shape tmp= default;
                if (isParsed && styleNumber > 0 && styleNumber < 4)
                {
                    switch (styleNumber)
                    {
                        case 1: tmpStyle = new HashStyle(color); break;
                        case 2: tmpStyle = new SnowStyle(color); break;
                        case 3: tmpStyle = new SmileyStyle(color); break;
                    }
                }
                else
                {
                    Console.WriteLine("You have chosen incorrect style number, please try again or type exit to exit.");
                    goto begin_style_choose;
                }
                switch (shapeId)
                {
                    case 1: tmp = new Triangle(tmpStyle, shapeSize); break;
                    case 2: tmp = new Rectangle(tmpStyle, shapeSize); break;
                    case 3: tmp = new Square(tmpStyle, shapeSize); break;
                    case 4: tmp = new Line(tmpStyle, shapeSize); break;
                    case 5: tmp = new Arrow(tmpStyle, shapeSize); break;
                    case 6: tmp = new Double_Arrow(tmpStyle, shapeSize); break;
                }
                tmp.Draw();
                tmp.Print();
            }
            //List<Shape> myShapes = new List<Shape>();

            //myShapes.Add(new Triangle(new HashStyle(color.Green), size.Small));
            //myShapes.Add(new Triangle(new SmileyStyle(color.Blue), size.Medium));
            //myShapes.Add(new Triangle(new SnowStyle(color.Red), size.Big));
            //myShapes.Add(new Line(new SmileyStyle(color.Yellow), size.Small));
            //myShapes.Add(new Line(new SnowStyle(color.White), size.Medium));
            //myShapes.Add(new Line(new HashStyle(color.Red), size.Big));
            //myShapes.Add(new Arrow(new SnowStyle(color.Green), size.Small, arrowdirection.Right));
            //myShapes.Add(new Arrow(new SmileyStyle(color.Magenta), size.Big, arrowdirection.Left));
            //myShapes.Add(new Double_Arrow(new SmileyStyle(color.Magenta), size.Small));
            //myShapes.Add(new Double_Arrow(new HashStyle(color.Red), size.Big));
            //myShapes.Add(new Rectangle(new HashStyle(color.Green), size.Small));
            //myShapes.Add(new Rectangle(new SmileyStyle(color.Cyan), size.Medium));
            //myShapes.Add(new Rectangle(new SnowStyle(color.DarkBlue), size.Big));
            //myShapes.Add(new Square(new HashStyle(color.DarkYellow), size.Small));
            //foreach (var shape in myShapes)
            //{
            //    shape.Draw();
            //    shape.Print();
            //}

            Console.ReadKey();
        }
    }
}


