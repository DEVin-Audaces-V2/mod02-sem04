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
            Pessoa pessoa1 = new Pessoa("Jaime", 18, "Rua XYZ.");

            // Validar acessos
            pessoa1.endereco = "Rua 123";

            pessoa1.saudacao();

            PessoaFilha pessoaFilha1 = new PessoaFilha();

            // pessoaFilha1.

        }
    }
}