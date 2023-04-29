using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class Pessoa
    {
        private String nome;
        protected int idade;
        public String endereco;

        public Pessoa(string nome, int idade, string endereco)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
        }

        public void saudacao()
        {
            Console.WriteLine($"Olá, meu nome é {nome} e eu tenho {idade} anos");
        }
    }
}