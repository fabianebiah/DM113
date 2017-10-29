using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
//using Cliente1.ServicoEstoque;
using projetoavaliativodm11301;

namespace Cliente1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cliente 1");
            Console.WriteLine("Press ENTER when the service has started");

            Console.ReadLine();
            ServicoEstoqueClient proxy = new ServicoEstoqueClient("BasicHttpBinding_IServicoEstoque");

            //Adicionar um Produto
            Console.WriteLine("1: Adicionar um Produto");
            EstoqueData novoProduto = new EstoqueData();
            novoProduto.NumeroProduto = "1";
            novoProduto.NomeProduto = "Novo Produto";
            novoProduto.DescricaoProduto = "Novo Produto";
            novoProduto.EstoqueProduto = 200;
            if (proxy.IncluirProduto(novoProduto))
            {
                Console.WriteLine("Produto incluído com sucesso");
            }
            else
            {
                Console.WriteLine("Falha ao inluir produto");
            }
            Console.WriteLine();


            //Excluir o produto 10;

            //Listar todos os Produtos  

            Console.WriteLine("Test 3: Listar Produtos");
            List<string> products = proxy.ListarProdutos().ToList();
            foreach (string p in products)
            {
                Console.WriteLine("Name: {0}", p);
                Console.WriteLine();
            }
            Console.WriteLine();

            //Exibir as informações do produto 2
            Console.WriteLine("4: Exibir informações do Produto 2");
            EstoqueData produto2 = proxy.VerProduto("2000");
           
                Console.WriteLine(produto2.NumeroProduto);
                Console.WriteLine(produto2.NomeProduto);
                Console.WriteLine(produto2.DescricaoProduto);
                Console.WriteLine(produto2.EstoqueProduto.ToString());
          

            Console.WriteLine();

            //Adicionar 10 unidades ao produto 2
            Console.WriteLine("5: Adicionar 10 unidades ao produto 2");
            if(proxy.AdicionarEstoque("2000", 10))
            {
                Console.WriteLine("Estoque do produto 2 adicionado com sucesso");
            }
            else
            {
                Console.WriteLine("Falha ao adicionar estoque ao produto 2");
            }
            Console.WriteLine();

            //Verificar o estoque do Produto 2

            Console.WriteLine("6: Verificar estoque Produto 2");
            int estoque2 = proxy.ConsultarEstoque("2000");
            Console.WriteLine(estoque2.ToString());
            
            Console.WriteLine();

            //Verificar estoque atual do produto 1
            Console.WriteLine("7: Verificar estoque Produto 1");
            int estoque1 = proxy.ConsultarEstoque("1000");
            Console.WriteLine(estoque1.ToString());

            Console.WriteLine();

            // Remover 20 unidades do produto 1
            Console.WriteLine("8: Remover 20 unidades do produto 1");

            if(proxy.RemoverEstoque("1000", 20))
            {
                Console.WriteLine("Estoque do produto 1 removido com sucesso");
            }
            else
            {
                Console.WriteLine("Falha ao remover estoque do produto 1");
            }

            Console.WriteLine();

            //Verificar estoque atual do produto 1
            Console.WriteLine("9: Verificar estoque atual do Produto 1");
            estoque1 = proxy.ConsultarEstoque("1000");
            Console.WriteLine(estoque1.ToString());

            Console.WriteLine();

            // Verificar todas as informações do produto 1
            Console.WriteLine("10: Exibir informações do Produto 1");
            EstoqueData produto1 = proxy.VerProduto("1000");
            Console.WriteLine(produto1.NumeroProduto);
            Console.WriteLine(produto1.NomeProduto);
            Console.WriteLine(produto1.DescricaoProduto);
            Console.WriteLine(produto1.EstoqueProduto);

            Console.WriteLine();

        }
    }
}
