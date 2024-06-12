using ExercicioMercado.Modelos;
class ExercicioMercadoProdutos
{
    List<Produtos> listaDeCompras = new();
    uint Quantidade { get; set; }
    double ValorUnitario { get; set; }
    string? Nome {  get; set; }
    double Valor {  get; set; }
    public void ExibirOpcoesDoMenu()
    {
        Console.Clear();
        Console.WriteLine("==============================");
        Console.WriteLine("====   Lista de Compras   ====");
        Console.WriteLine("==============================");
        Console.WriteLine("\n");
        Console.WriteLine("Digite 1 para adicionar um produto");
        Console.WriteLine("Digite 2 para mostrar todas os produtos");
        Console.WriteLine("Digite 3 para atualizar um produto");
        Console.WriteLine("Digite 4 para remover um produto");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                RegistrarProdutos();
                break;
            case 2:
                ListarProdutos();
                break;
            case 3:
                AtualizarProduto();
                break;
            case 4:
                RemoverProdutos();
                break;
            case -1:
                Console.WriteLine("Tchau Tchau :) ");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
    void RegistrarProdutos()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("============================");
            Console.WriteLine("===   LISTA DE COMPRAS   ===");
            Console.WriteLine("============================");
            Console.WriteLine("\n");

            Produtos produto = new(Nome!, Quantidade, ValorUnitario);

            Console.Write("Produto: ");
            produto.Nome = (Console.ReadLine()!);
            Console.Write("Quantidade: ");
            produto.Quantidade = uint.Parse(Console.ReadLine()!);
            Console.Write("Preço: ");
            produto.ValorUnitario = double.Parse(Console.ReadLine()!);

            listaDeCompras.Add(produto);

            Console.WriteLine("... Produto cadastrado com sucesso! ...");
            Console.ReadKey();
            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Houve algum problema {ex.Message}");
        }
        finally
        {
            ExibirOpcoesDoMenu();
        }
        
    }
    void ListarProdutos()
    {
        Console.Clear();
        double Total = 0;
        Console.WriteLine("==============================");
        Console.WriteLine("===    LISTA DE COMPRAS    ===");
        Console.WriteLine("==============================");
        Console.WriteLine("\n");
        if (listaDeCompras.Count <= 0)
        {
            Console.WriteLine("... Não há produtos cadastrados! ...");
            Console.ReadKey();
            return;
        }
        Console.WriteLine($"Produtos:     Quantidade:      Preço Unitário:");
       
        foreach (Produtos item in listaDeCompras)
        {
            Console.WriteLine($"{item.Nome!}              {item.Quantidade}               R${item.ValorUnitario}");
            
            double ValorUni = item.ValorUnitario;
            uint Quant = (uint)item.Quantidade!;
            Valor = ValorUni * Quant;
            Total += Valor;
        }
        Console.WriteLine($"\nTotal da compra: R${Total}");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }
    void AtualizarProduto()
     {
         Console.Clear();
         Console.WriteLine("=================================");
         Console.WriteLine("===     ATUALIZAR PRODUTO     ===");
         Console.WriteLine("=================================");
         Console.WriteLine("\n");
         Console.Write("Informe o nome do produto que deseja alterar: ");
         string nomeProduto = Console.ReadLine()!;
         Produtos produtos = null!;
     
        foreach (var item in listaDeCompras)
        {
            if (item.Nome!.Equals(nomeProduto))
            {
                produtos = item;
            }
        }
        if (produtos != null)
        { 
                Console.WriteLine("\nInforme o novo nome:");
                produtos.Nome = Console.ReadLine()!;
                Console.WriteLine("Informe a nova quantidade:");
                produtos.Quantidade = uint.Parse((Console.ReadLine()!).ToString());
                Console.WriteLine("Informe o novo valor:");
                produtos.ValorUnitario = double.Parse(Console.ReadLine()!);
        }
        ExibirOpcoesDoMenu();
        }
    void RemoverProdutos()
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("===      REMOVER PRODUTO     ===");
        Console.WriteLine("================================");
        Console.WriteLine("\n");
        Console.Write("Informe o nome do produto: ");
        string nomeProduto = Console.ReadLine()!;
        Produtos produtos = null!;
        foreach (var item in listaDeCompras)
        {
            if (item.Nome!.Equals(nomeProduto))
            {
                produtos = item;
            }
        }
        if (produtos != null)
        {
            listaDeCompras.Remove(produtos);
            Console.WriteLine("... Produto removido da lista! ...");
        }
        else
        {
            Console.WriteLine(" ... Produto para remoção não encontrado ...");
        }
        Console.ReadKey();

        ExibirOpcoesDoMenu();
    }
}

//agrogoticadac1