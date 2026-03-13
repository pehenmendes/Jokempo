using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokempoLibrary
{
    public class Estatisticas
    {
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
        public int Empates { get; set; }

        public void RegistrarVitoria()
        {
            Vitorias++;
        }

        public void RegistrarDerrota()
        {
            Derrotas++;
        }

        public void RegistrarEmpate()
        {
            Empates++;
        }
    }
}
