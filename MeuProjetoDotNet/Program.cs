using System;

internal class Programa
{
    private static void Main(string[] args)
    {
        char opcao;
        var aleatorio = new Random();
        int valor = 0, valordigitado = 0;

        Console.WriteLine(" ========================= JOGO DA ADIVINHACAO =========================");

        do
        {
            Console.WriteLine("(F) Facil - 😏");
            Console.WriteLine("(M) Medio - 🙄");
            Console.WriteLine("(D) Dificil - 😵");
            Console.WriteLine("Escolha a dificuldade do jogo:");
            opcao = char.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 'f':
                case 'F':
                    valor = aleatorio.Next(0, 11);
                    Console.Write("Adivinhe o valor (0-10): ");

                    for (int i = 3; i > 0; i--)
                    {
                        valordigitado = int.Parse(Console.ReadLine());

                        if (valordigitado == valor)
                        {
                            Console.WriteLine("Voce ganhou ! - 🙆");
                            break;
                        }
                        else if (valordigitado > valor)
                        {
                            Console.WriteLine("O valor escolhido eh menor");
                        }
                        else
                        {
                            Console.WriteLine("O valor digitado eh maior");
                        }

                        if (i == 1)
                        {
                            Console.WriteLine("Voce perdeu - 😈");
                        }
                    }
                    break;

                case 'm':
                case 'M':
                    valor = aleatorio.Next(0, 51);
                    Console.Write("Adivinhe o valor (0-50): ");

                    for (int i = 4; i > 0; i--)
                    {
                        valordigitado = int.Parse(Console.ReadLine());

                        if (valordigitado == valor)
                        {
                            Console.WriteLine("Voce ganhou ! - 🙆");
                            break;
                        }
                        else if (valordigitado > valor)
                        {
                            Console.WriteLine("O valor escolhido eh menor");
                        }
                        else
                        {
                            Console.WriteLine("O valor digitado eh maior");
                        }

                        if (i == 1)
                        {
                            Console.WriteLine("Voce perdeu - 😈");
                        }
                    }
                    break;

                case 'd':
                case 'D':
                    valor = aleatorio.Next(0, 101);
                    Console.Write("Adivinhe o valor (0-100): ");

                    for (int i = 5; i > 0; i--)
                    {
                        valordigitado = int.Parse(Console.ReadLine());

                        if (valordigitado == valor)
                        {
                            Console.WriteLine("Voce ganhou ! - 🙆");
                            break;
                        }
                        else if (valordigitado > valor)
                        {
                            Console.WriteLine("O valor escolhido eh menor");
                        }
                        else
                        {
                            Console.WriteLine("O valor digitado eh maior");
                        }

                        if (i > 1)
                        {
                            Console.WriteLine($"Voce possui ainda {i - 1} tentativa(s)");
                        }
                        else
                        {
                            Console.WriteLine("Voce perdeu - 😈");
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Valor digitado invalido");
                    break;
            }

            Console.WriteLine("Deseja jogar novamente? (S/N): ");
            opcao = char.Parse(Console.ReadLine());
        } while (opcao == 'S' || opcao == 's');
    }
}
