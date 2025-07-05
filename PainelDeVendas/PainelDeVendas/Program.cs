namespace PainelDeVendas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> ProdutoList = new List<Produto>();
            List<Venda> vendas = new List<Venda>();

            bool progRun = true;
            while (progRun)
            {
                Console.Clear();
                Console.WriteLine("1. Cadastrar novo produto." +
                                  "\n2. Listar produtos." +
                                  "\n3. Registrar nova venda." +
                                  "\n4. Listar vendas realizadas." +
                                  "\n5. Fechar programa.");
                if (!int.TryParse(Console.ReadLine(), out int op))
                {
                    Console.WriteLine("Entrada inválida. Pressione qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    continue;
                }

                switch (op)
                {
                    case 1:
                        Console.Write("Digite o nome do produto: ");
                        string name = Console.ReadLine();
                        Console.Write("Digite o preço do produto: ");
                        double preco = double.Parse(Console.ReadLine());
                        Console.Write("Digite a comissão: ");
                        double comissao = double.Parse(Console.ReadLine());
                        ProdutoList.Add(new Produto(name, preco, comissao));
                        break;
                    case 2:
                        foreach (Produto produto in ProdutoList)
                        {
                            Console.WriteLine(produto);
                        }
                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\nProdutos disponíveis:");
                        for (int i = 0; i < ProdutoList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}: {ProdutoList[i]}");
                        }
                        Console.Write("Escolha o número do produto vendido: ");
                        int escolha = int.Parse(Console.ReadLine()) - 1;

                        if (escolha >= 0 && escolha < ProdutoList.Count)
                        {
                            Produto produtoSelecionado = ProdutoList[escolha];
                            vendas.Add(new Venda(produtoSelecionado));
                            Console.WriteLine("Venda registrada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Produto inválido.");
                        }
                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\nVendas realizadas:");
                        double totalComissao = 0;

                        foreach (Venda v in vendas)
                        {
                            Console.WriteLine(v);
                            totalComissao += v.ProdutoVendido.Comissao;

                        }
                        Console.WriteLine($"Total de comissão: {totalComissao:C}");
                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Programa encerrado");
                        progRun = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}