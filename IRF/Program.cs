using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua forma de contratação?");
            Console.WriteLine("(A)ssalariado");
            Console.WriteLine("(C)omissionado");
            Console.WriteLine("(H)orista");
            string contrato = Console.ReadLine().ToUpper();

            switch(contrato)
            {
                case "A":
                    Console.WriteLine("Qual seu salário bruto?");
                    double sb = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual seu desconto? (em números)");
                    double desc = double.Parse(Console.ReadLine());
                    double slA = sb - desc;
                    Console.WriteLine("Seu salário liquido é: " + slA);

                    if(slA <= 2000)
                    {
                        Console.WriteLine("Seu irf é " + (slA * 0.075));
                    }
                    else if(slA > 200 && slA<=4000)
                    {
                        Console.WriteLine("Seu irf é " + (slA * 0.12));
                    }
                    else
                    {
                        Console.WriteLine("Seu irf é " + (slA * 0.15));
                    }
                    break;
                case "C":
                    Console.WriteLine("Quantidade de peças: ");
                    int qp = int.Parse(Console.ReadLine());
                    Console.WriteLine("Comissão por peças");
                    double vp = double.Parse(Console.ReadLine());
                    double slC = qp * vp;
                    Console.WriteLine("Seu salário liquido é: " + slC);

                    if (slC <= 2000)
                    {
                        Console.WriteLine("Seu irf é " + (slC * 0.075));
                    }
                    else if (slC > 200 && slC <= 4000)
                    {
                        Console.WriteLine("Seu irf é " + (slC * 0.12));
                    }
                    else
                    {
                        Console.WriteLine("Seu irf é " + (slC * 0.15));
                    }
                    break;
                case "H":
                    Console.WriteLine("Valor da hora: ");
                    int vh = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qunatidade de horas trabalhadas: ");
                    double qh = double.Parse(Console.ReadLine());
                    double slH= vh * qh;
                    Console.WriteLine("Seu salário liquido é: " + slH);

                    if (slH <= 2000)
                    {
                        Console.WriteLine("Seu irf é " + (slH * 0.075));
                    }
                    else if (slH > 200 && slH <= 4000)
                    {
                        Console.WriteLine("Seu irf é " + (slH * 0.12));
                    }
                    else
                    {
                        Console.WriteLine("Seu irf é " + (slH * 0.15));
                    }
                    break;
                default:
                    Console.WriteLine("Digte uma letra valida");
                    break;
            }

            Console.ReadKey();
        }
    }
}
