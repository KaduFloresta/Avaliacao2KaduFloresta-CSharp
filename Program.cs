using System;
using View;

/**
 *  @author Kadu Floresta
 * 
 * 
*/

namespace ViewLocadora
{
	public class Principal 
	{
		public static void Main(String[] args) 
		{	
		Repositories.ClienteRepositories.ImportarCliente();

		Console.WriteLine("LOCADORA DE FILMES MVC");

		// IdCliente / Menu
		int menu = 0;
		do 
		{ 
            Console.WriteLine("\n|********************************|");			  
              Console.WriteLine("|=============MENU===============|");
			  Console.WriteLine("|********************************|"); 
              Console.WriteLine("| 1 >>> Inserir Locação          |");
              Console.WriteLine("| 2 >>> Listar Clientes          |");
			  Console.WriteLine("| 3 >>> Listar Filmes            |");
			  Console.WriteLine("| 4 >>> Listar Locações           |");
              Console.WriteLine("|--------------------------------|");
			  Console.WriteLine("|********************************|\n");

			//Entrada Menu
			Console.WriteLine("\nDigite a Opção: ");
            String Digito = Console.ReadLine();
			menu = Convert.ToInt32(Digito);

			switch (menu)
			{
				case 1: //adicionar locacao
					break;
				case 2: //listar clientes
					ClienteView.GetClientes();
					break;
				case 3: //listar filmes
					//FilmeView.GetFilmes();
					break;
				case 4: //lista locação
					break;

			}
		} while (menu <= 5);
			
		}
	}
}