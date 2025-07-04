namespace PainelDeVendas
{
    internal class Produto
    {
        public string Name { get; set; }
        public double Preco { get; set; }
        public double Comissao { get; set; }

        public Produto() { }
        public Produto(string name, double preco, double comissao) { 
        
            Name = name;
            Preco = preco;
            Comissao = comissao;
        }

        public override string ToString()
        {
            return $"Produto: {Name}, Preço: {Preco:C}, Comissão: {Comissao:C}";
        }
    }
}
