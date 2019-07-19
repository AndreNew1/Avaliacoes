using System;
using System.Globalization;
namespace Avaliacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ANome = new string[5];
            double[] Notas = new double[5];
            int i = 0,aprovado=0,reprovado=0;
            double sum=0;

            try
            {
                //Recepção dos dados
                do
                {
                    Console.WriteLine("Digite o Nome do Aluno");
                    string Nome = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("Digite a Nota do Aluno");
                        double Nota = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                        //Tratamento de erro Notas
                        while (Nota > 10 || Nota < 0)
                        {
                            Console.WriteLine("Nota Invalida");
                            Console.WriteLine("Digite a Nota do Aluno");
                            Nota = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                        }
                        ANome[i] = Nome;
                        Notas[i] = Nota;
                        i++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("ERROR");
                        Console.ReadLine();
                    }
                    Console.Clear();
                } while (i < 5);

                //Imprimi Alunos Aprovados
                Console.WriteLine("Alunos Aprovados :");
                for (i = 0; i < 5; i++)
                {
                    sum += Notas[i];
                    if (Notas[i] >= 5)
                    {
                        aprovado++;
                        Console.WriteLine("Nome do Aluno: {0} Nota: {1} Estado: Aprovado", ANome[i], Notas[i]);
                    }
                    else
                    {
                        reprovado++;
                        Console.WriteLine("Nome do Aluno: {0} Nota: {1} Estado: Reprovado", ANome[i], Notas[i]);
                    }

                }
                //Media Sala
                double MediaSala = sum / 5;
                Console.WriteLine();
                Console.WriteLine("Media da Sala: " + MediaSala);

                //Porcentagem dos Alunos
                reprovado = reprovado * 20;
                aprovado = aprovado * 20;
                Console.WriteLine();
                Console.WriteLine("Alunos Aprovados: " + aprovado + "%");
                Console.WriteLine("Alunos Reprovados: " + reprovado + "%");
            }
            catch
            {

            }
        }
    }
}
