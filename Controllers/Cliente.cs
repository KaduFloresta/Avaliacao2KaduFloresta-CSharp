using Models;
using System.Collections.Generic;

namespace Controllers {

	public class ClienteController {

        public static void addCliente(int idCliente, string nome, string dataNasc, string cpf, int diaDev) {
            new Cliente(idCliente, nome, dataNasc, cpf, diaDev);
        }
        // Adição de Locações
        public string getCliente(Cliente cliente) {
			string clienteValue = cliente.ToString();

            clienteValue += $"-> QTDE LOCAÇÕES: {this.getLocacoes(cliente)}\n";
            clienteValue += "----------------------------------------";

            return clienteValue;
		}
        
		// Lista de locações
		public int getLocacoes(Cliente cliente) {
			int qtd = 0;

			foreach (Locacao locacao in cliente.locacoes) 
			{
				foreach (Filme filme in locacao.filmes) 
				{
					qtd++;
				}
			}

			return qtd;
		}

        public static List<Cliente> GetClientes(){
            return Cliente.GetClientes();
        }
    }
}