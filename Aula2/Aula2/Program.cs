using System;
using Aula2.Entidades;
namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        { char s;
            bool flex;
            Console.WriteLine("Digite o Nome do Carro");
            string Nome = Console.ReadLine();
            try
            { 
                Console.WriteLine("Digite o Data de Fabricação:");
                DateTime Data = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Digite a Marca:");
                string Marca = Console.ReadLine();
                Console.WriteLine("Digite o Pais do Carro:");
                string Pais = Console.ReadLine();
                Console.WriteLine("Digite a Quantidade de Portas:");
                int Portas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a Capacidade do Tanque:");
                double Capacidade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("O Carro é Flex?(s/n)");
                s = Convert.ToChar(Console.ReadLine());
                if (s == 's' || s == 'S')
                    flex = true;
                else
                    flex = false;
                Carro carrinho = new Carro(Nome,Data,Marca,Pais,Portas,Capacidade,flex);
                Console.WriteLine("Digite a Quantidade de Quilometros:");
                double Km = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a Quantidade de litros gastado:");
                double litro = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Km/l: {0}", carrinho.QuilometroLitro(Km, litro).ToString());
                Console.WriteLine("Km com Tanque Cheio: {0}", carrinho.Autonomia(Km, litro).ToString());
                Console.Write(carrinho.ToString());
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
