using System.Xml;

namespace ATV5_CJ3021955
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc_geral;



            Console.WriteLine("MENU DE EXERCÍCIOS\n\n1- EXERCÍCIO DA SALA DE AULA\n2- EXERCÍOCIO 1 - LISTA\n3- EXERCÍCIO 2 - LISTA\n4- EXERCÍCIO 3 - LISTA\n5- EXERCÍCIO 4 - LISTA\n6- EXERCÍCIO 5 - LISTA\n7- EXERCÍCIO 6 - LISTA\n8- EXERCÍCIO 7- LISTA ");
            Console.WriteLine("\nEscreva o número correspondente ao exercício: ");
            opc_geral = int.Parse(Console.ReadLine());



            switch (opc_geral)

            {

                case 1:

                    Console.WriteLine("ATIVIDADE DA SALA DE AULA");

                    int a, temp;
                    int soma = 0;

                    for (a = 0; a < 3; a++)

                    {
                        Console.WriteLine("digite um valor: ");
                        temp = int.Parse(Console.ReadLine());

                        if (temp < 0)

                        {
                            break;
                        }
                        soma = soma + temp;
                    }
                    Console.WriteLine("A média é {0}", soma / 3);
                    break;

                case 2:

                    Console.WriteLine("EXERCÍCIO 1 - LISTA");

                    int a1, n;

                    Console.WriteLine("Escreva um número inteiro aleatório: ");
                    n = int.Parse(Console.ReadLine());

                    for (a1 = 0; a1 <= n; a1++)

                    {
                        Console.WriteLine(a1);
                       
                    }
                    break;

                case 3:

                    Console.WriteLine("EXERCÍCIO 2 - LISTA");

                    int a2, n1;

                    Console.WriteLine("Escreva um número inteiro aleatório: ");
                    n1 = int.Parse(Console.ReadLine());

                    for (a2 = 0; a2 <= n1; a2++)

                    {
                       if (a2 % 2 == 0 )
                        {
                            Console.WriteLine(a2);
                        }

                    }
                    break;

                case 4:

                    Console.WriteLine("EXERCÍCIO 3 - LISTA");

                    int div = 1000;

                    Console.WriteLine("Escreva um úmero interiro MENOR que 1000");
                    int mil = int.Parse(Console.ReadLine());
                    
                    if (mil < 1000)
                    {
                        for (div = 1000; div >= mil; div--)
                        {
                            if ((div % 2) == 0)
                            {
                                Console.WriteLine(div);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("OPÇÃO INVÁLIDA");
                    }

                    break;

                case 5:

                    Console.WriteLine("EXERCÍCIO 4 - LISTA");

                    break;

                case 6:

                    Console.WriteLine("EXERCÍCIO 5 - LISTA");

                    break;

                case 7:

                    Console.WriteLine("EXERCÍCIO 6 - LISTA");

                    break;

                case 8:

                    Console.WriteLine("EXERCÍCIO 7 - LISTA");

                    break;

                default:

                    Console.WriteLine("Opção invalida");

                    break;



            }
        }
    }
}
