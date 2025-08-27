using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{

    internal class Fog : Terrain, IDebuf
    {
        public Fog(int wid, int hei) : base(wid, hei)
        {
            
        }

        public override void Activate()
        {
            Console.WriteLine();
        }

        public override void Describe()
        {
            Console.WriteLine("안개 지형");
        }
        public void Hiding()
        {
            Console.WriteLine("숨었다");
        }
    }
}
