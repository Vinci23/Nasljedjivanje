using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje
{
    class Cat
    {
        bool opasna;

        public bool Opasna { get => opasna; set => opasna = value; }

        public virtual void Opasnost()
        {
            opasna = false;
        }
    }

    class Gepard : Cat
    {
        public override void Opasnost()
        {
            Opasna = true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat maca = new Cat();
            maca.Opasnost();
            Console.WriteLine("Maca opasna? " + maca.Opasna);

            Gepard gepard = new Gepard();
            gepard.Opasnost();
            Console.WriteLine("Gepard opasan? " + gepard.Opasna);


            Console.ReadKey();
        }
    }
}
