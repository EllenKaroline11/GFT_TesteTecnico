namespace Produtos
{
    public class Produto
    {
        public Produto(string nome, double preco, int qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        public string Nome { get; }
        public double Preco { get; }
        public int Qtd { get; }
    }
}