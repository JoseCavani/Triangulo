using System;

namespace Triangulo.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sucesso;
            while (true)
            {
                static void verificarTriangulo(decimal x, decimal y,decimal z)
        {
                    if (x != y && x != z && y != z)
                    {
                        Console.WriteLine("o triango digitado e escaleno");
                    }
                    else if (x == y && x == z && y == z)
                    {
                        Console.WriteLine("o triango digitado e Eqüilátero");
                    }
                    else
                        Console.WriteLine("o triango digitado e Isósceles");
                }


            volta:
                Console.Write("digite 1 para verificar o tipo do triangulo\nDigite s para sair\n");
                string opcao = Console.ReadLine().ToLower();
                if (opcao != "s" && opcao != "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("opção invalido");
                    Console.ResetColor();
                    Console.ReadKey();
                    goto volta;
                }
                if (opcao == "s")
                    break;


                Console.Clear();
                voltaX:
                    Console.WriteLine("digite o primeiro lado");
                    sucesso = decimal.TryParse(Console.ReadLine(), out decimal x);
                    if (sucesso == false)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("numero invalido");
                        Console.ResetColor();
                        Console.ReadKey();
                        goto voltaX;
                    }
                voltaY:
                    Console.WriteLine("digite o segundo lado");
                    sucesso = decimal.TryParse(Console.ReadLine(), out decimal y);
                    if (sucesso == false)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("numero invalido");
                        Console.ResetColor();
                        Console.ReadKey();
                        goto voltaY;
                    }
                voltaZ:
                    Console.WriteLine("digite o terceiro lado");
                    sucesso = decimal.TryParse(Console.ReadLine(), out decimal z);
                    if (sucesso == false)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("numero invalido");
                        Console.ResetColor();
                        Console.ReadKey();
                        goto voltaZ;

                    }

                    if (x+y<z || z+y<x || x+z < y)
                {
                    Console.WriteLine("Triangulo invalido");
                    Console.ReadKey();
                    Console.Clear();
                    goto volta;
                }

                verificarTriangulo(x, y, z);
                Console.ReadKey();  
                Console.Clear();

            }
        }
    }
}
