using JokempoLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokempoLibrary
{
    public static class GameManager
    {
        public static JogoService Jogo { get; set; } = new JogoService();
    }
}
