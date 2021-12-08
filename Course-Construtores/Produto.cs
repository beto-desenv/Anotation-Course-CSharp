using System.Globalization;

namespace Course_Classes_2
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() { 
        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; // --> Por padrão, os atributos numéricos já recebem o valor "0"(zero), tornando está linha dispensavel,
                            //     sendo que se eu não coloca-la, naturalmente o valor será "0"(zero).
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) // Método resposável por adiocionar Produtos.
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) // Método resposável por remover Produtos.
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
