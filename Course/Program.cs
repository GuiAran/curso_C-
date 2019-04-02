using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Joao");

            foreach (string pessoa in lista)
            {
                Console.WriteLine(pessoa);
            }


        }
    }
}
