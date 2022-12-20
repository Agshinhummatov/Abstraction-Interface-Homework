using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction__Interface_Homework.Models
{
    internal abstract class Animal
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public virtual void Sound()
        {
            Console.WriteLine("Animal souand");
        }


        public abstract void Eating();


    }
}
