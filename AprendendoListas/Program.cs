using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> clientes = new List<string>();
            clientes.Add("Victor");
            clientes.Add("Lima");
            string pessoa = "José";
            clientes.Add(pessoa);
            clientes.Add("Victor");
            clientes.Add("Lima");
            clientes.Add(pessoa);
            clientes.Add(pessoa);

            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            //clientes.RemoveAt(1);
            int quant = clientes.RemoveAll(cliente => cliente == "José");

            Console.WriteLine("=========================");

            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            string busca = clientes.Find(cliente => cliente.Length < 5);

            if(busca == null)
            {
                Console.WriteLine("Não achou!");
            }


            List<string> filtrada = clientes.FindAll(cliente => cliente.Length < 5);

            foreach(string cliente in filtrada)
            {
                Console.WriteLine(cliente);
            }

            Console.WriteLine("=========================");
            Console.WriteLine(Convert.ToString(quant));
            Console.ReadKey();
        }
    }
}
