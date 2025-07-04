namespace PainelDeVendas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> ProdutoList = new List<Produto>();

            bool progRun = true;
            while (progRun)
            {
                Console.WriteLine("1. Cadastrar novo produto." +
                                  "\n2. Listar produtos." +
                                  "\n3. Fechar programa.");
                int op = int.Parse(Console.ReadLine());

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
                        break;
                    case 3:
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