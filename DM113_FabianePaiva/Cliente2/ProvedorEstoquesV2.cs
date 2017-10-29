﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projetoavaliativodm11302
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetoavaliativo.dm113/02", ConfigurationName="projetoavaliativodm11302.IServicoEstoque")]
    public interface IServicoEstoque
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoque/ConsultarEstoqueResponse")]
        int ConsultarEstoque(string NumProdut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoque/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumProdut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoque/AdicionarEstoqueResponse")]
        bool AdicionarEstoque(string NumProdut, int QuantProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoque/AdicionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumProdut, int QuantProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoque/RemoverEstoqueResponse")]
        bool RemoverEstoque(string NumProdut, int QuantProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoque/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumProdut, int QuantProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicoEstoqueChannel : projetoavaliativodm11302.IServicoEstoque, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoEstoqueClient : System.ServiceModel.ClientBase<projetoavaliativodm11302.IServicoEstoque>, projetoavaliativodm11302.IServicoEstoque
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
    }
}
