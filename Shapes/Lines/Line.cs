using Figures.Styles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Shapes.Lines
{
    class Line : Shape
    {
        public Line(IStyleable style, Size size) : base(style, size) { }
        public override void Draw()
        {
            ConsoleColor defaultcolor = Console.ForegroundColor;
            Console.ForegroundColor = Style.Color;
            Console.Write(new string(Style.Tool, (int)this.ShapeSize));
            Console.WriteLine();
            Console.ForegroundColor = defaultcolor;
        }
    }
}
