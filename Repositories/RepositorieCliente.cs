using Models;
using System.Collections.Generic;

namespace Repositories
{
    public class RepositoriesCliente
    {
		public static List<Cliente> clientes = new List<Cliente>();

		public static void importCliente(){
			// Lista com 5 Clientes
			Cliente cliente1 = new Cliente(1, "Adriano Medeiros Sá", "21/01/1978", "123.123.123-12", 3);
			clientes.Add(cliente1);
			Cliente cliente2 = new Cliente(2, "João Pedro Silva", "13/08/1945", "456.456.456-45", 2);
			clientes.Add(cliente2);
			Cliente cliente3 = new Cliente(3, "Maria de Fátima Antunes", "02/12/2001", "789.789.789-78", 3);
			clientes.Add(cliente3);
			Cliente cliente4 = new Cliente(4, "Letícia Eugenia Soares", "11/02/1988", "098.098.098-09", 2);
			clientes.Add(cliente4);
			Cliente cliente5 = new Cliente(5, "Belmiro Schmmitt", "15/07/1995", "753.753.753-75", 3);
			clientes.Add(cliente5);
		}
        
        
    }
}