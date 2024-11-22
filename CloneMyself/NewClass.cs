using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneMyself
{
    internal class NewClass
    {
        string name;
        string abilities;
        string usingAbilites;

        public NewClass(string name, string abilities, string usingAbilites)
        {
            this.name = name;
            this.abilities = abilities;
            this.usingAbilites = usingAbilites;
        }

        public void PrintText()
        {
            Console.WriteLine($"Jeg heter {name}, mine egenskaper er {abilities} og jeg bruker dem til {usingAbilites}");
        }
    }
}
