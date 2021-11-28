using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Styles
{
    interface IStyle
    {
        ConsoleColor Color { get; set; }
        char Tool { get; }
    }
}
