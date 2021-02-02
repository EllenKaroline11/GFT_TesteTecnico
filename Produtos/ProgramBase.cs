namespace Produtos
{
    internal class ProgramBase
    {
        private string nome;
        private double preco;
        private int qtd;

        public ProgramBase(string nome, double preco, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }

        static void Main(string[] args)
        {
    }
}