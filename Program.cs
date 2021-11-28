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
            List<Shape> myShapes = new List<Shape>();

            myShapes.Add(new Triangle(new HashStyle(color.Green), size.Small));
            myShapes.Add(new Triangle(new SmileyStyle(color.Blue), size.Medium));
            myShapes.Add(new Triangle(new SnowStyle(color.Red), size.Big));
            myShapes.Add(new Line(new SmileyStyle(color.Yellow), size.Small));
            myShapes.Add(new Line(new SnowStyle(color.White), size.Medium));
            myShapes.Add(new Line(new HashStyle(color.Red), size.Big));
            myShapes.Add(new Arrow(new SnowStyle(color.Green), size.Small, arrowdirection.Right));
            myShapes.Add(new Arrow(new SmileyStyle(color.Magenta), size.Big, arrowdirection.Left));
            myShapes.Add(new Double_Arrow(new SmileyStyle(color.Magenta), size.Small));
            myShapes.Add(new Double_Arrow(new HashStyle(color.Red), size.Big));
            myShapes.Add(new Rectangle(new HashStyle(color.Green), size.Small));
            myShapes.Add(new Rectangle(new SmileyStyle(color.Cyan), size.Medium));
            myShapes.Add(new Rectangle(new SnowStyle(color.DarkBlue), size.Big));
            myShapes.Add(new Square(new HashStyle(color.DarkYellow), size.Small));
            foreach (var shape in myShapes)
            {
                shape.Draw();
                shape.Print();
            }

            Console.ReadKey();
        }
    }
}


