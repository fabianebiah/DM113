using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using EstoqueEntityModel;
using System.ServiceModel.Activation;

namespace ProvedorEstoques {


    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service" no arquivo de código, svc e configuração ao mesmo tempo.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicoEstoque : IServicoEstoque
    {
        public bool AdicionarEstoque(string NumProduto, int QuantProduto)
        {
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                   
                    ProdutoEstoque prod = (from p in database.ProdutosEstoques
                                     where String.Compare(p.NumeroProduto, NumProduto) == 0
                                           select p).First();
                    prod.EstoqueProduto = prod.EstoqueProduto + QuantProduto;
                    database.SaveChanges();
                }
            }
            catch
            {
                // If an exception occurs, return false to indicate failure
                return false;
            }
            // Return true to indicate success
            return true;
        }

        public int ConsultarEstoque(string NumProdut)
        {
            int estoque = 0;
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Find the first product that matches the specified product code
                    ProdutoEstoque matchingProduct = database.ProdutosEstoques.First(
                    p => String.Compare(p.NumeroProduto, NumProdut) == 0);                    
                    {
                        estoque =  matchingProduct.EstoqueProduto;
                    };
                    
                }
             }
            catch 
            {
                return -1;
            }
            return estoque;


         }

        public bool IncluirProduto(EstoqueData Produto)
        {
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque ProdToSave = new ProdutoEstoque();
                    ProdToSave.NumeroProduto = Produto.NumeroProduto;
                    ProdToSave.NomeProduto = Produto.NomeProduto;
                    ProdToSave.DescricaoProduto = Produto.DescricaoProduto;
                    ProdToSave.EstoqueProduto = Produto.EstoqueProduto;
                    database.ProdutosEstoques.Add(ProdToSave);
                    // Save the change back to the database
                    database.SaveChanges();
                }
            }
            catch
            {
                // If an exception occurs, return false to indicate failure
                return false;
            }
            // Return true to indicate success
            return true;

        }

        public List<string> ListarProdutos()
        {
            List<string> productsList = new List<string>();
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Fetch the products in the database
                    List<ProdutoEstoque> products = (from product in database.ProdutosEstoques select product).ToList();
                    foreach (ProdutoEstoque product in products)
                    {
                        productsList.Add(product.NomeProduto);
                    }
                }
            }
            catch
            {
                // Ignore exceptions in this implementation
            }
            // Return the list of products
            return productsList;

        }

                

        public bool RemoverEstoque(string NumProduto, int QuantProduto)
        {

            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {

                    ProdutoEstoque prod = (from p in database.ProdutosEstoques
                                           where String.Compare(p.NumeroProduto, NumProduto) == 0
                                           select p).First();
                    int estoque = prod.EstoqueProduto - QuantProduto;
                    if (estoque > 0){
                        prod.EstoqueProduto = estoque;
                    }
                    else {
                        prod.EstoqueProduto = 0;
                    }
                    database.SaveChanges();
                }
            }
            catch
            {
                // If an exception occurs, return false to indicate failure
                return false;
            }
            // Return true to indicate success
            return true;
        }   

        public bool RemoverProduto(string NumProduto)
        {
            //TODO A ser modificado ainda   
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {

                    ProdutoEstoque prod = (from p in database.ProdutosEstoques
                                           where String.Compare(p.NumeroProduto, NumProduto) == 0
                                           select p).First();
                    database.ProdutosEstoques.Remove(prod);
                    database.SaveChanges();
                }

            }
            catch
            {
                return false;
            }
            // Return the product
            return true;
        }

        public EstoqueData VerProduto(string NumProduto)
        {

            EstoqueData produtoData = null;
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Find the first product that matches the specified product code
                    ProdutoEstoque matchingProduct = database.ProdutosEstoques.First(
                    p => String.Compare(p.NumeroProduto, NumProduto) == 0);
                    produtoData = new EstoqueData()
                    {
                        NumeroProduto = matchingProduct.NumeroProduto,
                        NomeProduto = matchingProduct.NomeProduto,
                        DescricaoProduto = matchingProduct.DescricaoProduto,
                        EstoqueProduto = matchingProduct.EstoqueProduto
                    };
                }
            }
            catch
            {
                // Ignore exceptions in this implementation
            }
            // Return the product
            return produtoData;
        }
    }
}
