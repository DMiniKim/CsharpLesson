using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Item
    {
        private string name;
        private int strength;
        private int dexterity;
        private int intelligence;

        public string Name { get { return name; } set { name = value; } }
        public int Strength { get { return strength; } set { strength = value; } }
        public int Dexterity { get { return dexterity; } set { dexterity = value; } }
        public int Intelligence { get { return intelligence; } set { intelligence = value; } }

        public Item(string id, int power, int dexterity, int intelligence)
        {
            this.name = id;
            this.strength = power;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }
        
    }
}
