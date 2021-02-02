using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    class Loja : Livro, VideoGame
    {
        private string nome { get; set; }
    private string cnpj { get; set; }

    private List<Livro> livros;

    private List<VideoGame> videoGames;
        private int tema;

        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
    {
        this.nome = nome;
        this.cnpj = cnpj;
        this.livros = livros;
        this.videoGames = videoGames;
    }

    public void listaLivros()
    {
        if (livros.Length <= 0)
        {
            Console.WriteLine("A loja não tem livros no seu estoque");
        }
        else
        {
            for (int i = 0; i < livros.Length; i++)
            {
                Console.WriteLine("Nome: " + livros[i].get => nome);
                Console.WriteLine("Autor: " + livros[i].get => autor);
                Console.WriteLine("Tema: " + livros[i].get => tema);

            }
        }
    }

    public void listaVideoGames()
    {
        if (videoGames.Length <= 0)
        {
            Console.WriteLine("A loja não tem videogames no seu estoque");
        }
        else
        {
            for (int i = 0; i < videoGames.Length; i++)
            {
                Console.WriteLine("Marca: " + livros[i].get => marca);
                Console.WriteLine("Modelo: " + livros[i].get => modelo);
            }
        }
    }

    public double calculaPatrimonio()
    {
        double soma = 0;

        for (int i = 0; i < livros.Length; i++)
        {
            soma += livros[i].Get => preco;
        }
        for (int i = 0; i < videoGames.Length; i++)
        {
            soma += videoGames[i].get => preco;
        }

        return soma;
    }

}

        
    }

