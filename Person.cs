using System;
using System.Collections.Generic;
using System.Text;

namespace Kompozyt_Wzorce_proj_
{
    public abstract class Person
    {
        public string Name { get; set; }
        public abstract void CallToArms();
        
    }
    public class Squire : Person
    {
        public override void CallToArms()
        {
            Console.WriteLine($"Melduje się germek {Name}!");
        }
    }
    public class Liege : Person
    {
        public List<Person> ListOfVassals { get; set; }
        public override void CallToArms()
        {
            foreach (Person vassal in ListOfVassals)
            {
                vassal.CallToArms();
            }
            Console.WriteLine($"Melduje się {Name}, wezwałem do walki  {ListOfVassals.Count}!");
        }
    }
}
