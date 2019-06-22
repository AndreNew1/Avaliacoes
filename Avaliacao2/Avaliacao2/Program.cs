using System;

namespace Avaliacao2
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {

                Console.WriteLine("Digite os palavras: ");
                string NUM = Console.ReadLine();
                Console.WriteLine("Replace string: {0}", NUM.Replace(" ", ","));
                Console.WriteLine();
                Console.WriteLine("Digite uma frase:");
                string Frase = Console.ReadLine();
                Console.WriteLine("Digite uma palavra que existe na frase passada");
                string Procura = Console.ReadLine();
                bool T = Frase.Contains(Procura);
                Console.WriteLine("Na Frase {0} a palavra {1}",Frase,Procura);
                if (T)
                {
                    int local = Frase.IndexOf(Procura);
                    if (local >= 0)
                        Console.WriteLine("Comeca na letra {0}", local + 1);
                }
                else
                    Console.WriteLine("A palavra não existe na frase escrita");
                Console.WriteLine();
                Console.WriteLine("Digite uma palavra ou frase:");
                string Palavra = Console.ReadLine();
                Console.WriteLine("Em maiusculo: {0}", Palavra.ToUpper());
                Console.WriteLine("Em minusculo: {0}", Palavra.ToLower());
                for(int i = 0; i < Palavra.Length; i++)
                {
                    Console.Write("{0} ", Palavra[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Digite um nome:");
                string Nome = Console.ReadLine();
                char[] Trim = { 'a', 'A', 'e', 'E' };
                string Resultado = Nome.Trim(Trim);
                string Resul = Nome.TrimEnd(Trim);
                string Result = Nome.TrimStart(Trim);
                Console.WriteLine("Trim: {0}",Resultado);
                Console.WriteLine("TrimEnd: {0}",Resul);
                Console.WriteLine("TrimStart: {0}",Result);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Obrigado pelo uso");
                Console.ReadLine();
            }
  
        }
    }
}
