using Figures.Styles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Shapes.Lines
{
    class Arrow : Shape
    {
        public ArrowDirection Direction { get; set; } 
        public Arrow(IStyle style, Size size, ArrowDirection direction = ArrowDirection.Left) : base(style, size)
        {
            Direction = direction;
        }
        public override void Draw()
        {
            ConsoleColor defaultcolor = Console.ForegroundColor;
            Console.ForegroundColor = Style.Color;
            if (Direction == ArrowDirection.Left)
            {
                Console.WriteLine(new string(' ', (int)this.ShapeSize - 6) + Style.Tool + Style.Tool);
                Console.WriteLine(new string(' ', (int)this.ShapeSize - 4) + Style.Tool + Style.Tool);
                Console.WriteLine(new string(Style.Tool, (int)this.ShapeSize));
                Console.WriteLine(new string(' ', (int)this.ShapeSize - 4) + Style.Tool + Style.Tool);
                Console.WriteLine(new string(' ', (int)this.ShapeSize - 6) + Style.Tool + Style.Tool);
            }
            else
            {
                Console.WriteLine($"  {Style.Tool}{Style.Tool}");
                Console.WriteLine($" {Style.Tool}{Style.Tool}");
                Console.WriteLine(new string(Style.Tool, (int)this.ShapeSize));
                Console.WriteLine($" {Style.Tool}{Style.Tool}");
                Console.WriteLine($"  {Style.Tool}{Style.Tool}");
            }

            Console.WriteLine();
            Console.ForegroundColor = defaultcolor;
        }
        public enum ArrowDirection
        {
            Left = 0,
            Right = 1
        }
    }
}
