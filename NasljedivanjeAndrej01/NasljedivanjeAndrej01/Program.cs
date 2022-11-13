using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljedivanjeAndrej01
{

    class Cat
    {
        public bool opasna;

        public virtual void Opasnost()
        {
            this.opasna = false;
        }
        
    }
    class Gepard : Cat
    {
        public override void Opasnost()
        {
            this.opasna = true;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.Opasnost();
            Gepard g = new Gepard();
            g.Opasnost();
            Console.WriteLine("Gepard opasna: "+ g.opasna + " \nMačka opasna: " + c.opasna);
            Console.ReadKey();
        }
    }
}
