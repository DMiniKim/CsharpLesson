using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Mercenary : IDamageable,IMoveable
    {
        public void Move()
        {
            Console.WriteLine("Move");
        }
        public void TakeDamage(int damage)
        {
            Console.WriteLine("damage : " + damage);
        }
    }
}
