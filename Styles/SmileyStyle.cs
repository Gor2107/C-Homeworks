using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Styles
{
    class SmileyStyle : IStyle
    {
        public ConsoleColor Color { get; set; }
        public char Tool { get; } = (char)2;
        public SmileyStyle(ConsoleColor color) => Color = color;
    }
}
