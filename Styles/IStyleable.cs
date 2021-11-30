using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Styles
{
    interface IStyleable
    {
        ConsoleColor Color { get; set; }
        char Tool { get; }
    }
}
