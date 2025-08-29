using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Merchant : Entity , ITradeable
    {
        public Merchant(string name) : base(name)
        {
           
        }
        public void Deal()
        {
            Console.WriteLine("shop open");
        }
    }
}
