using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // permite que a gente defina uma classe ou objeto de maneira mais genérica
                // Não específica todos os detalhes
            // Define a essência/principal/core de classe

            Cachorro romeu = new Cachorro();

            romeu.EmitirSom();
        }
    }
}