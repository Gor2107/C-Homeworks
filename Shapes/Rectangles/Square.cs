using Figures.Styles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Shapes.Rectangles
{
    class Square:Shape
    {
        public Square(IStyleable style, Size size) : base(style, size) { }
        public override void Draw()
        {
            ConsoleColor defaultcolor = Console.ForegroundColor;
            Console.ForegroundColor = Style.Color;
            for (int i = 0; i < (int)this.ShapeSize / 2; i++)
            {
                Console.WriteLine(new string(Style.Tool, (int)this.ShapeSize));
            }
            Console.WriteLine();
            Console.ForegroundColor = defaultcolor;
        }
    }
}
