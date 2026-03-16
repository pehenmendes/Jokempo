using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JokempoLibrary.Models
{
    public class Jogador
    {
        public string Nome { get; set; }

        public Estatisticas Estatisticas { get; set; } = new Estatisticas();

        public Jogador(string nome)
        {
            Nome = nome;
        }
    }
}
