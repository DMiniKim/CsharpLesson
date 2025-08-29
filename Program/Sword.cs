using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Sword : IUpgradeable
    {
        private string name;
        private int strength;
        private int dexterity;
        private int intelligence;
        public Sword(string name, int str,int dex ,int intel)
        {
            this.name = name;
            this.strength = str; 
            this.dexterity = dex;
            this.intelligence = intel;
        }
        public void Upgrade()
        {
            this.strength += 10;
            Console.WriteLine(strength);
            Console.WriteLine(dexterity);
            Console.WriteLine(intelligence);
        }

    }
}
