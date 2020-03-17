using Models;
using System.Collections.Generic;

namespace Controllers 
{

	public class ClienteController 
	{
        public static void addCliente(int idCliente, string nomeCliente, string dataNascimento, string cpfCliente, int diasDevolucao) 
			{
				new ClienteModels(idCliente, nomeCliente, dataNascimento, cpfCliente, diasDevolucao);
			}

        // Adição de Locações
        public string getCliente(ClienteModels cliente) 
			{
				string clienteValue = cliente.ToString();

				clienteValue += $"-> QTDE LOCAÇÕES: {this.getLocacoes(cliente)}\n";
				clienteValue += "----------------------------------------";

				return clienteValue;
			}
        
		// Lista de locações
		public int getLocacoes(ClienteModels cliente) 
		{
			int qtd = 0;

			foreach (LocacaoModels locacao in cliente.locacoes) 
			{
				foreach (FilmeModels filme in locacao.filmes) 
				{
					qtd++;
				}
			}

			return qtd;
		}

        public static List<ClienteModels> GetClientes()
			{
				return ClienteModels.GetClientes();
			}
    }
}