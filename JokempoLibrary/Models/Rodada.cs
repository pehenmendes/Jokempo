using JokempoLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokempoLibrary.Models
{
    public class Rodada
    {
        public Escolha EscolhaJogador { get; set; }

        public Escolha EscolhaMaquina { get; set; }

        public string Resultado { get; set; }
    }
}
