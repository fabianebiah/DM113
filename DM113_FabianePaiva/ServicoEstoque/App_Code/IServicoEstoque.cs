using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService" no arquivo de código e configuração ao mesmo tempo.
namespace ProvedorEstoques
{
    [ServiceContract]
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