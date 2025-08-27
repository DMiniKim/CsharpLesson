using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal abstract class Terrain
    {
        protected int width;
        protected int height;

        protected int Width { get { return width; } set { width = value; } }
        protected int Height { get { return height; } set { height = value; } }

        public abstract void Activate();
        public abstract void Describe();
        public Terrain(int wid , int hei)
        {
            width = wid; height = hei;
        }
    }
}
