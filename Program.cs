using System;
using Figures.Shapes;
using Figures.Styles;
using Figures.Shapes.Lines;
using Size = Figures.Shapes.Shape.Size;
using Color = System.ConsoleColor;
using arrowdirection = Figures.Shapes.Lines.Arrow.ArrowDirection;
using Figures.Shapes.Rectangles;
using System.Collections.Generic;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {


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
            Paint();
            Console.ReadKey();
        }
        public static int ChooseShape() {
        begin_again:
            Console.WriteLine("Choose shape from list below to print");
            Console.WriteLine(" 1-Triangle");
            Console.WriteLine(" 2-Recangle");
            Console.WriteLine(" 3-Square");
            Console.WriteLine(" 4-Line");
            Console.WriteLine(" 5-Arrow");
            Console.WriteLine(" 6-Doble Arrow");
            Console.WriteLine("\t\t\tType \"exit\"-to exit application");
            string text = Console.ReadLine();
            if (text.ToLower() == "exit") return -1;
            bool isParsed = int.TryParse(text, out  int shapeId);
            if (!isParsed || !(0 < shapeId && shapeId < 7))
            {
                Console.WriteLine("You have chosen incorrect shape number, please try again or type exit to exit.");
                goto begin_again;
            }
            return shapeId;
        }
        public static int ChooseShapeSize()
        {
            string text;
        begin_size_choose:
            Console.WriteLine("Choose shape size from list below");
            Console.WriteLine($"{(int)Size.Small}-{Size.Small}");
            Console.WriteLine($"{(int)Size.Medium}-{Size.Medium}");
            Console.WriteLine($"{(int)Size.Big}-{Size.Big}");
            Console.WriteLine("\t\t\tType \"exit\"-to exit application");
            text = Console.ReadLine();
            if (text.ToLower() == "exit") return -1;
           bool isParsed = int.TryParse(text, out int shapeSizeInt);
           
            if (isParsed && Enum.IsDefined(typeof(Size), shapeSizeInt))
            {              
                return shapeSizeInt;
            }
            else
            {
                Console.WriteLine("You have chosen incorrect shape size, please try again or type exit to exit.");
                goto begin_size_choose;
            }
        }
        
        public static int ChooseShapeColor()
        {
            string text;
        begin_color_choose:
            Console.WriteLine("Choose shape color from list below");
Console.WriteLine(@"Black = 0,
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
            Console.WriteLine("\t\t\tType \"exit\"-to exit application");
            text = Console.ReadLine();
            if (text.ToLower() == "exit") return -1;
            bool isParsed = int.TryParse(text, out int colorNumber);
            if (isParsed && Enum.IsDefined(typeof(Color), colorNumber))
            {
                return colorNumber;
            }
            else
            {
                Console.WriteLine("You have chosen incorrect color number, please try again or type exit to exit.");
                goto begin_color_choose;
            }
        }

        public static int ChooseStyleNumber()
        {
            string text;
        begin_style_choose:
            Console.WriteLine("Choose shape style from list below");
            Console.WriteLine("\t\t\tType \"exit\"-to exit application");
            Console.WriteLine($"1-Hash Style");
            Console.WriteLine($"2-Snow Style");
            Console.WriteLine($"3-Smiley Style");
            text = Console.ReadLine();
            if (text.ToLower() == "exit") return -1;
           bool isParsed = int.TryParse(text, out int styleNumber);
            if (isParsed && styleNumber > 0 && styleNumber < 4)
            {
                return styleNumber;
            }
            else
            {
                Console.WriteLine("You have chosen incorrect style number, please try again or type exit to exit.");
                goto begin_style_choose;
            }
        }


        public static void Paint()
        {
            while (true)
            {
                Shape tmp = default;
                IStyleable tmpStyle = default;
                Color color;
                Size shapeSize;
                int shapeId= ChooseShape();
                if (shapeId == -1) return;
                int shapeSizeInt= ChooseShapeSize();
                if (shapeSizeInt == -1) return;
                shapeSize = (Size)shapeSizeInt;
                int colorNumber = ChooseShapeColor();
                if (colorNumber == -1) return;
                color=(Color)colorNumber;
                int styleNumber = ChooseStyleNumber();
                if (styleNumber == -1) return;
                switch (styleNumber)
                {
                    case 1: tmpStyle = new HashStyle(color); break;
                    case 2: tmpStyle = new SnowStyle(color); break;
                    case 3: tmpStyle = new SmileyStyle(color); break;
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
        }
    }
}


