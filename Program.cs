using System;
using ExemploSobrescrita.Classes;

namespace ExemploSobrescrita
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan m = new MegaMan();
            Zero z = new Zero();

            Console.WriteLine(m.Pular());
            Console.WriteLine(m.Correr());

            Console.WriteLine(z.Correr());
            Console.WriteLine(z.Pular());
        }
    }
}
