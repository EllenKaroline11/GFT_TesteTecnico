using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    class Livro
    {
        public class Livro : Produto, Imposto
        {
            private string autor { get; set; }
            private string tema { get; set; }

            private int qtdPag { get; set; }

            public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(nome, preco, qtd)
            {
                this.autor = autor;
                this.tema = tema;
                this.qtdPag = qtdPag;
            }

            public Livro(string autor, string tema, int qtdPag)
            {
                this.autor = autor;
                this.tema = tema;
                this.qtdPag = qtdPag;
            }

            public double CalculaImposto
            {
                get
                {
                    if (tema == "educativo")
                    {
                        qtdPag = qtdPag;
                    }
                    else
                    {
                        qtdPag += Convert.ToInt32(qtdPag * 0.10);
                    }
                }
            }
        }
    }
}
