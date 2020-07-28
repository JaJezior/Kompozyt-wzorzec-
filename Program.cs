using System;
using System.Collections.Generic;

namespace Kompozyt_Wzorce_proj_
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.Run();
        }

        private void Run()
        {
            var pacholek1 = new Squire() { Name = "Gienek1", };
            var pacholek2 = new Squire() { Name = "Gienek2", };
            var pacholek3 = new Squire() { Name = "Gienek3", };
            var pacholek4 = new Squire() { Name = "Gienek4", };
            var pacholek5 = new Squire() { Name = "Gienek5", };
            var pacholek6 = new Squire() { Name = "Gienek6", };
            var pacholek7 = new Squire() { Name = "Gienek7", };
            var pacholek8 = new Squire() { Name = "Gienek8", };
            var pacholek9 = new Squire() { Name = "Gienek9", };
            var pacholek10 = new Squire() { Name = "Gienek10"};

            var rycerz1 = new Liege() { Name = "Zbyszko z Bysewa", ListOfVassals = new List<Person>() { pacholek1, pacholek2, pacholek3 } };
            var rycerz2 = new Liege() { Name = "Maćko z Przymuszewa", ListOfVassals = new List<Person>() { pacholek4, pacholek5, pacholek6 } };
            var rycerz3 = new Liege() { Name = "Qrwinox z Huwdu", ListOfVassals = new List<Person>() { pacholek7, pacholek8} };
            var hrabia1 = new Liege() { Name = "Hans von Wieppke", ListOfVassals = new List<Person>() { rycerz1, pacholek9, pacholek10 } };
            var hrabia2 = new Liege() { Name = "Hrabia Montekrystian", ListOfVassals = new List<Person>() { rycerz2, rycerz3} };


            var theKing = new Liege() { Name = "Król Janek III Sobie Niebieski", ListOfVassals = new List<Person>() { hrabia1, hrabia2 } };

            theKing.CallToArms();
        }
    }
}
