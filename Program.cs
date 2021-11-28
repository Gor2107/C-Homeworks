using System;
using Figures.Shapes;
using Figures.Styles;
using Figures.Shapes.Lines;
using size = Figures.Shapes.Shape.Size;
using color = System.ConsoleColor;
using arrowdirection = Figures.Shapes.Lines.Arrow.ArrowDirection;
using Figures.Shapes.Rectangles;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Triangles
            //Green small triangle
            Shape smalltriangle = new Triangle(new HashStyle(color.Green), size.Small);
            smalltriangle.Draw();
            smalltriangle.Print();
            //Blue medium triangle
            Shape smalltriangle2 = new Triangle(new SmileyStyle(color.Blue), size.Medium);
            smalltriangle2.Draw();
            smalltriangle2.Print();
            //Big red triangle
            Shape smalltriangle1 = new Triangle(new SnowStyle(color.Red), size.Big);
            smalltriangle1.Draw();
            smalltriangle1.Print();

            #endregion

            #region Lines
            #region Line
            Shape line = new Line(new SmileyStyle(color.Yellow), size.Small);
            line.Draw();
            line.Print();
            Shape line1 = new Line(new SnowStyle(color.White), size.Medium);
            line1.Draw();
            line1.Print();
            Shape line2 = new Line(new HashStyle(color.Red), size.Big);
            line2.Draw();
            line2.Print();
            #endregion
            #region Arrow
            Shape arrow = new Arrow(new SnowStyle(color.Green), size.Small, arrowdirection.Right);
            arrow.Draw();
            arrow.Print();
            Shape arrow1 = new Arrow(new SmileyStyle(color.Magenta), size.Big, arrowdirection.Left);
            arrow1.Draw();
            arrow1.Print();
            #endregion
            #region Double_arrow
            Shape dblArrow = new Double_Arrow(new SmileyStyle(color.Magenta), size.Small);
            dblArrow.Draw();
            dblArrow.Print();
            Shape dblArrow1 = new Double_Arrow(new HashStyle(color.Red), size.Big);
            dblArrow1.Draw();
            dblArrow1.Print();
            #endregion
            #endregion
            #region Rectangles
            #region Rectangle
            Shape rectangle = new Rectangle(new HashStyle(color.Green), size.Small);
            rectangle.Draw();
            rectangle.Print();
            Shape rectangle2 = new Rectangle(new SmileyStyle(color.Cyan), size.Medium);
            rectangle2.Draw();
            rectangle2.Print();
            Shape rectangle3 = new Rectangle(new SnowStyle(color.DarkBlue), size.Big);
            rectangle3.Draw();
            rectangle3.Print();
            #endregion
            #region Square
            Shape square = new Square(new HashStyle(color.DarkYellow),size.Small);
            square.Draw();
            square.Print();
            #endregion
            #endregion
            Console.ReadKey();
        }
    }
}


