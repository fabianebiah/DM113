using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoavaliativodm11302;


namespace Cliente2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cliente 2");
            Console.WriteLine("Press ENTER when the service has started");

            Console.ReadLine();
             ServicoEstoqueClient proxy = new ServicoEstoqueClient("WS2007HttpBinding_IServicoEstoque");
            //ServicoEstoqueClient proxy = new ServicoEstoqueClient();

            Console.WriteLine("1: Verificar estoque Produto 1");
            int estoque2 = proxy.ConsultarEstoque("1000");
            Console.WriteLine(estoque2.ToString());

            Console.WriteLine();

            //Adicionar 20 unidades ao produto 1
            Console.WriteLine("2: Adicionar 20 unidades ao produto 1");
            if (proxy.AdicionarEstoque("1000", 10))
            {
                Console.WriteLine("Estoque do produto 1 adicionado com sucesso");
            }
            else
            {
                Console.WriteLine("Falha ao adicionar estoque ao produto 1");
            }
            Console.WriteLine();


            Console.WriteLine("3: Verificar estoque Produto 1");
            estoque2 = proxy.ConsultarEstoque("1000");
            Console.WriteLine(estoque2.ToString());

            Console.WriteLine();


            Console.WriteLine("4: Verificar estoque Produto 5");
            estoque2 = proxy.ConsultarEstoque("5000");
            Console.WriteLine(estoque2.ToString());

            Console.WriteLine();

            //Remover 50 unidades do produto 5
            Console.WriteLine("5: Remover 10 unidades do produto 5");
            if (proxy.RemoverEstoque("5000", 10))
            {
                Console.WriteLine("Estoque do produto 5 removido com sucesso");
            }
            else
            {
                Console.WriteLine("Falha ao remover estoque do produto 5");
            }
            Console.WriteLine();


            Console.WriteLine("6: Verificar estoque Produto 5");
            estoque2 = proxy.ConsultarEstoque("5000");
            Console.WriteLine(estoque2.ToString());

            Console.WriteLine();
        }
    }
}
