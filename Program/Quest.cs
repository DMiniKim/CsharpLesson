using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Quest
    {
        private string title;
        private string description;

        private bool completed = false;

        private Reward rewards;
        public Quest(string title, string description, Reward reward)
        {
            this.title = title;
            this.description = description;
            this.rewards = reward;
        }
        public void Describe()
        {
            Console.WriteLine("Title : " + title);
            Console.WriteLine("description : " + description);
            rewards.Describe();
        }

    }
}
