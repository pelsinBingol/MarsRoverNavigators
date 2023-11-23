using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCodeBase
{
    public class Plateau
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Plateau(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }

}
