using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoFila
{
    internal class FilaPessoa
    {
        public Pessoa Head { get; set; }
        public Pessoa Tail { get; set; }

        public int quantidade { get; set; }

        public int achei{ get; set; }

        public FilaPessoa()
        {
            Head = null;
            Tail = null;
            quantidade = 0;
            achei = 0;
        }
        
        public void Push(Pessoa novaPessoa)
        {
            if (Vazia())
            {
                Head = novaPessoa;
                Tail = novaPessoa;                
            }
            else
            {
                Tail.Proximo = novaPessoa;
                Tail = novaPessoa;               
            }
            quantidade++;
        }       

        public void Print()
        {
            if (Vazia())
            {
                Console.WriteLine("=====FILA VAZIA=====");
            }
            else
            {
                Console.WriteLine("Clientes na Fila");
                Pessoa aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                }while(aux != null);
            }
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("=====FILA VAZIA=====");
            }
            else
            {
                Head = Head.Proximo;
                if(Head == null)
                {
                    Tail = null;
                }
                quantidade--;
                Console.WriteLine("Pessoa saiu da fila");
            }           
        }

        public void BuscaNome(string nome)
        {
            if (Vazia())
            {
                Console.WriteLine("=====FILA VAZIA=====");
            }
            else
            {
                Pessoa aux = Head;
                do
                {
                    if (nome.Contains(aux.Nome))
                    {
                        Console.WriteLine(aux.ToString());
                        achei ++;
                    }
                    aux = aux.Proximo;
                }while(aux != null);

                if(achei == 0)
                {
                    Console.WriteLine("Cliente não está na fila");
                }
            }
        }

        public bool Vazia()
        {
            if((Head == null) && (Tail == null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
