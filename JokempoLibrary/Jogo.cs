using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokempoLibrary
{
    public class Jogo
    {
        private Random random = new Random();

        public List<Jogador> Jogadores { get; set; }

        public Jogador JogadorAtual { get; set; }

        public Jogo()
        {
            Jogadores = new List<Jogador>();
        }

        public void AdicionarJogador(string nome)
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

            rodada.CalcularResultado();

            AtualizarEstatisticas(rodada.Resultado);

            return rodada;
        }

        private void AtualizarEstatisticas(string resultado)
        {
            if (resultado == "Vitória")
                JogadorAtual.Estatisticas.RegistrarVitoria();

            else if (resultado == "Derrota")
                JogadorAtual.Estatisticas.RegistrarDerrota();

            else
                JogadorAtual.Estatisticas.RegistrarEmpate();
        }
    }
}
