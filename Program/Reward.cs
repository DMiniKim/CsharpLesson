using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Reward
    {
        private float exp;
        private int gold;
        public Reward(float exp, int gold)
        {
            this.exp = exp;
            this.gold = gold;
        }
        public void Describe()
        {
            Console.WriteLine("Exp : " + exp);
            Console.WriteLine("Gold : " + gold);
        }
    }
}
