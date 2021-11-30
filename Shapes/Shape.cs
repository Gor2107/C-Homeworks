using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Figures.Styles;

namespace Figures.Shapes
{
    abstract class Shape
    {
        public Size ShapeSize { get; set; }
        protected IStyleable Style { get; set; }
        public Shape(IStyleable style, Size size)
        {
            Style = style;
            ShapeSize = size;
        }
        public abstract void Draw();
        public virtual void Print()
        {
            string text = $"{this.ShapeSize} " + $"{this.Style.Color} " + $"{(this.ToString().Split('.'))[this.ToString().Split('.').Length - 1]}";
            if (text.Length <= (int)this.ShapeSize)
            { Console.Write(new string(' ', ((int)ShapeSize - text.Length) / 2)); }
            Console.WriteLine(text.ToUpper());
            Console.WriteLine();
        }

        public enum Size
        {
            Small = 20,
            Medium = 30,
            Big = 40
        }
    }
}
