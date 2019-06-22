using System;
using System.Globalization;

namespace CalculadoraR
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B;
            int I = 0;
            char K, H;
            double RESUL;
            double[] D = new double[5];
            for (int i = 0; i <= 4; i++)
            {
                D[i] = D[0];
            }
            do
            {
                //recepção de dados
                Console.WriteLine("Digite o Numero 1 :");
                string temp = Console.ReadLine();
                bool F = IsNumeric(temp);
                if (F == true)
                {
                    A = Convert.ToDouble(temp, CultureInfo.InvariantCulture);
                    Console.WriteLine("Digite o operador :");
                    temp = Console.ReadLine();
                    F = IsChar(temp);
                    if (F == true)
                    {
                        K = char.Parse(temp);
                        Console.WriteLine("Digite o Numero 2 :");
                        temp = Console.ReadLine();
                        F = IsNumeric(temp);
                        if (F == true)
                        {
                            B = Convert.ToDouble(temp, CultureInfo.InvariantCulture);
                            RESUL = 0;

                            //Decidi Calculo

                            if (K == '+')
                            {
                                Console.WriteLine("O Resultado da Soma é:" + SOMA(A, B));
                                RESUL = SOMA(A, B);
                            }
                            else if (K == '-')
                            {
                                Console.WriteLine("O Resultado da Subtração é:" + SUB(A, B));
                                RESUL = SUB(A, B);
                            }
                            else if (K == '*')
                            {
                                Console.WriteLine("O Resultado da Multiplicação é:" + MULT(A, B));
                                RESUL = MULT(A, B);
                            }
                            else if (K == '/')
                            {
                                if ( B == 0)
                                    Console.WriteLine(ERROR());
                                else
                                    Console.WriteLine("O Resultado da Divisão é:" + DIV(A, B));
                                RESUL = DIV(A, B);
                            }
                            else if (K == '%')
                            {
                                if (PORCEN(A, B) == 0)
                                    Console.WriteLine(ERROR());
                                else
                                    Console.WriteLine("O Resultado é:" + PORCEN(A, B));
                                RESUL = PORCEN(A, B);
                            }
                            else if (K == '#')
                            {
                                Console.WriteLine("O Resultado é:" + POTEN(A, B));
                                RESUL = POTEN(A, B);
                            }
                            else Console.WriteLine(ERROR());
                            // Armazena Historico
                            for (int i = 0; i < 4; i++)
                            {
                                D[i] = D[i + 1];
                            }
                            D[4] = RESUL;

                        }
                        else Console.WriteLine(ERROR());
                    }
                    else Console.WriteLine(ERROR());
                }
                else Console.WriteLine(ERROR());

                Console.WriteLine("Deseja Continuar?(s/n)");
                H = char.Parse(Console.ReadLine());
                Console.Clear();

            } while (H == 's'||H=='S');

            Console.WriteLine("Deseja o historico?(s/n)");
            H = char.Parse(Console.ReadLine());
            do
            {
                //Leitura Historico
                if (H == 's' || H == 'S')
                {
                    for (int i = 4; i >= I; i--)
                    {
                            Console.WriteLine("Resultados= " + D[i].ToString());
                    }

                }
                Console.WriteLine("Deseja limpar o historico?(s/n)");
                H = char.Parse(Console.ReadLine());
                    if (H == 's' || H == 'S')
                    {
                        for (int i = 4; i >= I; i--)
                        {
                            D[i] = 0;
                            Console.WriteLine();
                        }
                    }
                Console.WriteLine("Deseja o historico denovo?(s/n)");
                H = char.Parse(Console.ReadLine());
            } while (H == 's' || H == 'S');
        }
        //Procedimentos da Calculadora
        static double SOMA(double A, double B) { return A + B; }
        static double SUB(double A, double B) { return A - B; }
        static double MULT(double A, double B) { return A * B; }
        static double DIV(double A, double B)  { return A / B; } 
        static double PORCEN(double A, double B) {
            if ((B != 0) && (A != 0))
                return A * (B / 100);
            return 0;
        }
        static double POTEN(double A, double B)
        {
            double C = A;
            for (int i = 0; i < B - 1; i++)
            {
                A = A * C;
            }
            return A;
        }
        //Testes de erros
        static bool IsChar(String TesteString)
        {
            string VARIAVEIS = TesteString;

            if (VARIAVEIS == "+")
                return true;
            else if (VARIAVEIS == "-")
                return true;
            else if (VARIAVEIS == "*")
                return true;
            else if (VARIAVEIS == "/")
                return true;
            else if (VARIAVEIS == "#")
                return true;
            else if (VARIAVEIS == "n" || VARIAVEIS == "N")
                return true;
            else if (VARIAVEIS=="s"||VARIAVEIS=="S")
                return true;
            else
                return false;
           
        }
        static bool IsNumeric(string TESTEValor)
        {
            char[] VARIAVEIS = TESTEValor.ToCharArray();
            foreach (var TESTES in VARIAVEIS)
            {
                if (!char.IsDigit(TESTES))
                    return false;
            }

            return true;
        }
        static string ERROR()
        {
           return "ERROR";
        }

    }

}
