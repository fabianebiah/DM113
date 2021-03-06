﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projetoavaliativodm11301
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EstoqueData", Namespace="http://schemas.datacontract.org/2004/07/ProvedorEstoques")]
    public partial class EstoqueData : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DescricaoProdutoField;
        
        private int EstoqueProdutoField;
        
        private string NomeProdutoField;
        
        private string NumeroProdutoField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoProduto
        {
            get
            {
                return this.DescricaoProdutoField;
            }
            set
            {
                this.DescricaoProdutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EstoqueProduto
        {
            get
            {
                return this.EstoqueProdutoField;
            }
            set
            {
                this.EstoqueProdutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeProduto
        {
            get
            {
                return this.NomeProdutoField;
            }
            set
            {
                this.NomeProdutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroProduto
        {
            get
            {
                return this.NumeroProdutoField;
            }
            set
            {
                this.NumeroProdutoField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetoavaliativo.dm113/01", ConfigurationName="projetoavaliativodm11301.IServicoEstoque")]
    public interface IServicoEstoque
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutos", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutosResponse")]
        string[] ListarProdutos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutos", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutosResponse")]
        System.Threading.Tasks.Task<string[]> ListarProdutosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProdutoResponse")]
        bool IncluirProduto(projetoavaliativodm11301.EstoqueData Produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProdutoResponse")]
        System.Threading.Tasks.Task<bool> IncluirProdutoAsync(projetoavaliativodm11301.EstoqueData Produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProdutoResponse")]
        bool RemoverProduto(string NumProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProdutoResponse")]
        System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string NumProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoqueResponse")]
        int ConsultarEstoque(string NumProdut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumProdut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoqueResponse")]
        bool AdicionarEstoque(string NumProdut, int QuantProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumProdut, int QuantProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoqueResponse")]
        bool RemoverEstoque(string NumProdut, int QuantProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumProdut, int QuantProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProdutoResponse")]
        projetoavaliativodm11301.EstoqueData VerProduto(string NumProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProdutoResponse")]
        System.Threading.Tasks.Task<projetoavaliativodm11301.EstoqueData> VerProdutoAsync(string NumProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicoEstoqueChannel : projetoavaliativodm11301.IServicoEstoque, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoEstoqueClient : System.ServiceModel.ClientBase<projetoavaliativodm11301.IServicoEstoque>, projetoavaliativodm11301.IServicoEstoque
    {
        
        public ServicoEstoqueClient()
        {
        }
        
        public ServicoEstoqueClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ServicoEstoqueClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ServicoEstoqueClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ServicoEstoqueClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string[] ListarProdutos()
        {
            return base.Channel.ListarProdutos();
        }
        
        public System.Threading.Tasks.Task<string[]> ListarProdutosAsync()
        {
            return base.Channel.ListarProdutosAsync();
        }
        
        public bool IncluirProduto(projetoavaliativodm11301.EstoqueData Produto)
        {
            return base.Channel.IncluirProduto(Produto);
        }
        
        public System.Threading.Tasks.Task<bool> IncluirProdutoAsync(projetoavaliativodm11301.EstoqueData Produto)
        {
            return base.Channel.IncluirProdutoAsync(Produto);
        }
        
        public bool RemoverProduto(string NumProduto)
        {
            return base.Channel.RemoverProduto(NumProduto);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string NumProduto)
        {
            return base.Channel.RemoverProdutoAsync(NumProduto);
        }
        
        public int ConsultarEstoque(string NumProdut)
        {
            return base.Channel.ConsultarEstoque(NumProdut);
        }
        
        public System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumProdut)
        {
            return base.Channel.ConsultarEstoqueAsync(NumProdut);
        }
        
        public bool AdicionarEstoque(string NumProdut, int QuantProduto)
        {
            return base.Channel.AdicionarEstoque(NumProdut, QuantProduto);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumProdut, int QuantProduto)
        {
            return base.Channel.AdicionarEstoqueAsync(NumProdut, QuantProduto);
        }
        
        public bool RemoverEstoque(string NumProdut, int QuantProduto)
        {
            return base.Channel.RemoverEstoque(NumProdut, QuantProduto);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumProdut, int QuantProduto)
        {
            return base.Channel.RemoverEstoqueAsync(NumProdut, QuantProduto);
        }
        
        public projetoavaliativodm11301.EstoqueData VerProduto(string NumProduto)
        {
            return base.Channel.VerProduto(NumProduto);
        }
        
        public System.Threading.Tasks.Task<projetoavaliativodm11301.EstoqueData> VerProdutoAsync(string NumProduto)
        {
            return base.Channel.VerProdutoAsync(NumProduto);
        }
    }
}
