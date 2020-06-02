using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crime
{
    class Program
    {
        static void Main(string[] args)
        {
            int sim = 0;
            string resposta;
            
            Console.Write("Telefonou para a vitima?: ");
            resposta = Console.ReadLine();

            if(resposta == "sim")
            {
                sim++;
            }

            Console.Write("Esteve no local do crime?: ");
            resposta = Console.ReadLine();

            if (resposta == "sim")
            {
                sim++;
            }

            Console.Write("Mora perto da vitia?: ");
            resposta = Console.ReadLine();

            if (resposta == "sim")
            {
                sim++;
            }

            Console.Write("Devia para a vitima?: ");
            resposta = Console.ReadLine();

            if (resposta == "sim")
            {
                sim++;
            }

            Console.Write("Ja trabalhou com a vitima?: ");
            resposta = Console.ReadLine();

            if (resposta == "sim")
            {
                sim++;
            }

            if(sim == 2)
            {
                Console.Write("Suspeita");
            }

            if(sim >= 3 && sim <= 4)
            {
                Console.Write("Cumplice");
            }

            if(sim == 5)
            {
                Console.Write("Assassino");
            }

            if (sim == 0)
            {
                Console.Write("Inocente");
            }

            Console.ReadLine();
        }
    }
}
