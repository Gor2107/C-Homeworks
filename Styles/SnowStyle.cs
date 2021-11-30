using Figures.Styles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Styles
{
    class SnowStyle : IStyleable
    {
        public ConsoleColor Color { get; set; }
        public char Tool { get; } = (char)42;
        public SnowStyle(ConsoleColor color) => Color = color;
    }
}