using System;
using System.Collections.Generic;


class Program
{
    static Random random = new Random();

    // Estrutura para guardar estatísticas
    class Estatistica
    {
        public int Vitorias = 0;
        public int Derrotas = 0;
        public int Empates = 0;
    }

    static Dictionary<string, Estatistica> jogadores = new Dictionary<string, Estatistica>();
    static string jogadorAtual = "";

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== JOGO JOKENPO ===");
        Console.WriteLine("😀 Olá! Vamos jogar Jokempo?");

        int opcao = LerInteiro("1 - Sim ou 0 - Não\n= ", 0, 1);
        int continuar;

        TrocarJogador();

        while (opcao != 0)
        {
            opcao = Menu();

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\n=== JOGANDO ===");
                    do
                    {
                        Jogar();
                        continuar = LerInteiro("\nDeseja jogar novamente? 1 - Sim ou 0 - Não\n", 0, 1);

                    } while (continuar == 1);
                    Console.WriteLine("\n===============\n");
                    break;

                case 2:
                    TrocarJogador();
                    break;

                case 3:
                    MostrarEstatisticas();
                    break;

                case 0:
                    Console.WriteLine("Saindo do jogo. Até mais 👋");
                    Console.WriteLine("\n====================");
                    break;
            }

        } ;
    }

    static int Menu()
    {
        Console.WriteLine("\n=== MENU ===");
        Console.WriteLine("\nJogador atual: " + jogadorAtual);
        Console.WriteLine("1 - Jogar");
        Console.WriteLine("2 - Trocar jogador");
        Console.WriteLine("3 - Ver estatísticas");
        Console.WriteLine("0 - Sair");

        int aux = LerInteiro("Escolha uma opção: ", 0, 3);
        Console.WriteLine("\n============\n");
        return aux;
    }

    static void Jogar()
    { 
        int jogador = LerInteiro("\nEscolha: \n1-Pedra ✊ \n2-Papel 🖐️ \n3-Tesoura ✌️\n= ", 1, 3);
        int maquina = random.Next(1, 4);

        Console.WriteLine("Máquina escolheu: " + ConverterEscolha(maquina));

        string resultado = VerificarResultado(jogador, maquina);

        AtualizarEstatisticas(resultado);

        Console.WriteLine("Resultado: " + resultado);
    }

    static string VerificarResultado(int jogador, int maquina)
    {
        if (jogador == maquina)
            return "Empate";

        if ((jogador == 1 && maquina == 3) ||
            (jogador == 2 && maquina == 1) ||
            (jogador == 3 && maquina == 2))
            return "Vitória";

        return "Derrota";
    }

    static void AtualizarEstatisticas(string resultado)
    {
        if (resultado == "Vitória")
            jogadores[jogadorAtual].Vitorias++;
        else if (resultado == "Derrota")
            jogadores[jogadorAtual].Derrotas++;
        else
            jogadores[jogadorAtual].Empates++;
    }

    static void TrocarJogador()
    {
        Console.Write("\nDigite o nome do jogador: ");
        string nome = Console.ReadLine();

        jogadorAtual = nome;

        if (!jogadores.ContainsKey(nome))
            jogadores[nome] = new Estatistica();
    }

    static void MostrarEstatisticas()
    {
        Console.WriteLine("\n=== ESTATÍSTICAS ===");

        foreach (var jogador in jogadores)
        {
            Console.WriteLine("\nJogador: " + jogador.Key);
            Console.WriteLine("Vitórias: " + jogador.Value.Vitorias);
            Console.WriteLine("Derrotas: " + jogador.Value.Derrotas);
            Console.WriteLine("Empates: " + jogador.Value.Empates);
        }
        Console.WriteLine("\n==================\n");
    }

    static int LerInteiro(string mensagem, int min, int max)
    {
        int valor;

        while (true)
        {
            Console.Write(mensagem);

            if (int.TryParse(Console.ReadLine(), out valor) && valor >= min && valor <= max)
                return valor;

            Console.WriteLine("Entrada inválida. Tente novamente.");
        }
    }

    static string ConverterEscolha(int escolha)
    {
        switch (escolha)
        {
            case 1: return "Pedra";
            case 2: return "Papel";
            case 3: return "Tesoura";
            default: return "";
        }
    }
}