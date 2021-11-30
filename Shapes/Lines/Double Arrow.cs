using Figures.Styles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Shapes.Lines
{
    class Double_Arrow : Shape
    {
        public Double_Arrow(IStyleable style, Size size) : base(style, size)
        { }

        public override void Draw()
        {
            ConsoleColor defaultcolor = Console.ForegroundColor;
            Console.ForegroundColor = Style.Color;

            Console.Write($"  {Style.Tool}{Style.Tool}");
            Console.WriteLine(new string(' ', (int)this.ShapeSize - 10) + Style.Tool + Style.Tool);
            Console.Write($" {Style.Tool}{Style.Tool}");
            Console.WriteLine(new string(' ', (int)this.ShapeSize - 7) + Style.Tool + Style.Tool);

            Console.WriteLine(new string(Style.Tool, (int)this.ShapeSize));

            Console.Write($" {Style.Tool}{Style.Tool}");
            Console.WriteLine(new string(' ', (int)this.ShapeSize - 7) + Style.Tool + Style.Tool);
            Console.Write($"  {Style.Tool}{Style.Tool}");
            Console.WriteLine(new string(' ', (int)this.ShapeSize - 10) + Style.Tool + Style.Tool);

            Console.WriteLine();
            Console.ForegroundColor = defaultcolor;

        }
    }
}
