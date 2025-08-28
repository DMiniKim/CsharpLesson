using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Enchant
    {
        public void Enhance(Item item)
        {
            if (item.Name == "검")
            {
                item.Strength += 10;
            }
            else if (item.Name == "목걸이")
            {
                item.Intelligence += 10;
            }
            else if (item.Name == "신발")
            {
                item.Dexterity += 10;
            }
        }
    }
}
