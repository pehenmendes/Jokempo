using JokempoLibrary.Enums;
using JokempoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokempoLibrary.Services
{
    public class JogoService
    {
        private Random random = new Random();

        public List<Jogador> Jogadores { get; private set; } = new List<Jogador>();

        public Jogador JogadorAtual { get; private set; }

        public void CriarJogador(string nome)
        {
            Jogador jogador = new Jogador(nome);

            Jogadores.Add(jogador);

            JogadorAtual = jogador;
        }

        public Rodada Jogar(Escolha escolhaJogador)
        {
            Rodada rodada = new Rodada();

            rodada.EscolhaJogador = escolhaJogador;
            rodada.EscolhaMaquina = (Escolha)random.Next(1, 4);

            rodada.Resultado = CalcularResultado(rodada);

            AtualizarEstatisticas(rodada.Resultado);

            return rodada;
        }

        private string CalcularResultado(Rodada rodada)
        {
            if (rodada.EscolhaJogador == rodada.EscolhaMaquina)
                return "Empate";

            if (
                (rodada.EscolhaJogador == Escolha.Pedra && rodada.EscolhaMaquina == Escolha.Tesoura) ||
                (rodada.EscolhaJogador == Escolha.Papel && rodada.EscolhaMaquina == Escolha.Pedra) ||
                (rodada.EscolhaJogador == Escolha.Tesoura && rodada.EscolhaMaquina == Escolha.Papel)
            )
                return "Vitória";

            return "Derrota";
        }

        private void AtualizarEstatisticas(string resultado)
        {
            if (JogadorAtual == null)
                return;

            if (resultado == "Vitória")
                JogadorAtual.Estatisticas.Vitorias++;

            else if (resultado == "Derrota")
                JogadorAtual.Estatisticas.Derrotas++;

            else
                JogadorAtual.Estatisticas.Empates++;
        }
    }
}
