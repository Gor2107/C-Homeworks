using Figures.Styles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Shapes
{
    class Triangle : Shape
    {
        public Triangle(IStyle style, Size size) : base(style, size) { }
        public override void Draw()
        {
            int j = 1;
            ConsoleColor defaultcolor = Console.ForegroundColor;
            Console.ForegroundColor = Style.Color;
            for (int i = 0; i < (int)this.ShapeSize && (((int)this.ShapeSize - j) / 2) > 0; i++)
            {
                Console.Write(new string(' ', ((int)this.ShapeSize - j) / 2));
                Console.Write(new string(Style.Tool, j));
                Console.Write(new string(' ', ((int)this.ShapeSize - j) / 2));
                j += 2;
                Console.WriteLine();
            }
            Console.ForegroundColor = defaultcolor;
        }
    }
}
