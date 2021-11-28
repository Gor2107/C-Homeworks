using Figures.Styles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Styles
{
    class HashStyle : IStyle
    {
        public ConsoleColor Color { get; set; }
        public char Tool { get; } = (char)35;
        public HashStyle(ConsoleColor color) => Color = color;
    }
}
