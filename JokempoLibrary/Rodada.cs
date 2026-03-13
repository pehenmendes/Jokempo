using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokempoLibrary
{
    public class Rodada
    {
        public Escolha EscolhaJogador { get; set; }
        public Escolha EscolhaMaquina { get; set; }

        public string Resultado { get; set; }

        public void CalcularResultado()
        {
            if (EscolhaJogador == EscolhaMaquina)
                Resultado = "Empate";

            else if (
                (EscolhaJogador == Escolha.Pedra && EscolhaMaquina == Escolha.Tesoura) ||
                (EscolhaJogador == Escolha.Papel && EscolhaMaquina == Escolha.Pedra) ||
                (EscolhaJogador == Escolha.Tesoura && EscolhaMaquina == Escolha.Papel)
            )
                Resultado = "Vitória";

            else
                Resultado = "Derrota";
        }
    }
}
