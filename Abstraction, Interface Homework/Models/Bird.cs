using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction__Interface_Homework.Models
{
    internal class Bird : Animal
    {
        public string Type { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Brid sound");
      
        }
        public override void Eating()
        {
            Console.WriteLine("Bird eating");

        }

    }
}
