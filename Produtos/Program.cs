using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    class Program : ProgramBase
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


        public class VideoGame : Produto
        {
            private string marca;
            private string modelo;
            private bool isUsado;

            public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
            {
                this.marca = marca;
                this.modelo = modelo;
                this.isUsado = isUsado;
            }
        }
    }
    }


