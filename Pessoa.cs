using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoFila
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Senha { get; set; }
        public Pessoa Proximo { get; set; }

        public Pessoa(string nome, int senha)
        {
            Nome = nome;
            Senha = senha;
            Proximo = null;
        }

        public override string ToString()
        {
            return "\nSENHA: "+Senha+"\nCLIENTE: "+ Nome;
        }
    }
}
