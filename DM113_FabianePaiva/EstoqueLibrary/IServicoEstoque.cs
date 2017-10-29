using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.Security;

// OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService" no arquivo de código e configuração ao mesmo tempo.
namespace ProvedorEstoques
{
    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/01", Name = "IServicoEstoque")]
    public interface IServicoEstoque
    {
        // Get all products
        [OperationContract]
        List<string> ListarProdutos();

        [OperationContract]
        bool IncluirProduto(EstoqueData Produto);

        [OperationContract]
        bool RemoverProduto(string NumProduto);

        [OperationContract]
        int ConsultarEstoque(string NumProdut);

        [OperationContract]
       bool AdicionarEstoque(string NumProdut, int QuantProduto);

        [OperationContract]
        bool RemoverEstoque(string NumProdut, int QuantProduto);

        [OperationContract]
        EstoqueData VerProduto(string NumProduto);
    }

    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/02", Name = "IServicoEstoque")]
    public interface IServicoEstoqueV2
    {
        // Get all products

        [OperationContract]
        int ConsultarEstoque(string NumProdut);

        [OperationContract]
        bool AdicionarEstoque(string NumProdut, int QuantProduto);

        [OperationContract]
        bool RemoverEstoque(string NumProdut, int QuantProduto);

    }



    // Data contract describing the details of a product passed to client applications
    [DataContract]
    public class EstoqueData

    {
        [DataMember]
        public string NumeroProduto;
        [DataMember]
        public string NomeProduto;
        [DataMember]
        public string DescricaoProduto;
        [DataMember]
        public int EstoqueProduto;
    }

}