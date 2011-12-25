using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TetrisReturn;

namespace MapInterface
{
    public interface MapInterface
    {
        string VietNameseName { get; }
        string VietNameseDescription { get; }
        string EnglishName { get; }
        string EnglishDescription { get; }

        Map map { get; }

        void Initialize();
        void Dispose();
    }
}
