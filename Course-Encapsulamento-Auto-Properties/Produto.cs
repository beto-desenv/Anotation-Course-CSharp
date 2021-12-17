using System.Globalization;

namespace Course_Encapsulamento_Auto_Properties
{
    class Produto
    {
        private string _nome; // <== Nesse caso, não é possivel usar o AUTO PROPERTIES devido a Lógica aplicada à Propriedade.
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set // Lógica de negócio, não permite que o valor seja VAZIO e que seja somente MAIOR que "1" 
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
