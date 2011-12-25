using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThemeInterface
{
    interface ThemInterface
    {
        string VietNameseName { get; }
        string VietNameseDescription { get; }
        string EnglishName { get; }
        string EnglishDescription { get; }

        Theme theme { get; }

        void Initialize();
        void Dispose();
    }
}