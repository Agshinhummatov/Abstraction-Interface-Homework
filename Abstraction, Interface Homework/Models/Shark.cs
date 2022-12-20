using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction__Interface_Homework.Models
{
    internal class Shark : Animal
    {

        public string TeethCount { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Shark Sound");
        }

        public override void Eating()
        {
            Console.WriteLine("Shark eating");
        }
    }
}




