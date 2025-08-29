using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Shoes :IUpgradeable
    {
        private string name;
        private int strength;
        private int dexterity;
        private int intelligence;
        public Shoes(string name,int strength, int dexterity, int intelligence)
        {
            this.name = name;
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }
        public void Upgrade()
        {
            this.dexterity += 10;
            Console.WriteLine(strength);
            Console.WriteLine(dexterity);
            Console.WriteLine(intelligence);
        }
    }
}
