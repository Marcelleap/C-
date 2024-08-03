using System;

internal class Programa
{
    private static void Main(string[] args)
    {
        char opcao;
        string palavraForca;
        int numero;
        string[] palavras = { "programacao", "computador", "teclado", "monitor", "csharp" };
        var aleatorio = new Random();

        do
        {
            Console.WriteLine(" ========================= JOGO DA FORCA =========================");

            // Sorteio da palavra
            numero = aleatorio.Next(palavras.Length);
            palavraForca = palavras[numero];
            char[] palavraExibida = new char[palavraForca.Length];
            for (int i = 0; i < palavraForca.Length; i++)
            {
                palavraExibida[i] = '_';
            }

            string letrasUsadas = "";
            int tentativas = 6;
            bool ganhou = false;

            while (tentativas > 0 && !ganhou)
            {
                Console.WriteLine($"\nPalavra: {new string(palavraExibida)}");
                Console.WriteLine($"Letras usadas: {letrasUsadas}");
                Console.WriteLine($"Tentativas restantes: {tentativas}");
                Console.Write("Digite uma letra: ");
                char letra = char.Parse(Console.ReadLine().ToLower());

                if (letrasUsadas.Contains(letra))
                {
                    Console.WriteLine("Você já utilizou essa letra. Tente outra.");
                    continue;
                }

                letrasUsadas += letra + " ";

                bool acertou = false;
                for (int i = 0; i < palavraForca.Length; i++)
                {
                    if (palavraForca[i] == letra)
                    {
                        palavraExibida[i] = letra;
                        acertou = true;
                    }
                }

                if (!acertou)
                {
                    tentativas--;
                }

                ganhou = !new string(palavraExibida).Contains('_');
            }

            if (ganhou)
            {
                Console.WriteLine($"\nParabéns! Você ganhou! A palavra era: {palavraForca}");
            }
            else
            {
                Console.WriteLine($"\nVocê perdeu. A palavra era: {palavraForca}");
            }

            Console.WriteLine("Deseja jogar novamente? (S/N): ");
            opcao = char.Parse(Console.ReadLine().ToLower());
        } while (opcao == 's');
    }
}
