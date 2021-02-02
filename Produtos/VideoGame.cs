using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    class VideoGame: Produto, Imposto
    {

        
        private string marca { get; set; }
        private string modelo { get; set; }

        private bool isUsado { get; set; }

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.isUsado = isUsado;
        }

        public double CalculaImposto()
        {
            if (isUsado == true)
            {
                preco += + (preco * 0.25);
            }
            else
            {
                preco += + (preco * 0.45);

            }
        }
}
