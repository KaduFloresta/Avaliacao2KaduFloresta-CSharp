using System;
using NameLocacao;
using View;
using Models;

/**
 *  @author Kadu Floresta
 * 
 * 
*/

namespace ViewLocadora
{
public class Principal {

	public static void Main(String[] args) {      
	
		Repositories.RepositoriesCliente.importCliente();

		Console.WriteLine("LOCADORA DE FILMES MVC");

		// IdCliente / Menu
		int idCliente = 0;
		Locacao locacao;
		do { 
            Console.WriteLine("\n|********************************|");			  
              Console.WriteLine("|=============MENU===============|");
			  Console.WriteLine("|********************************|"); 
              Console.WriteLine("| 1 >>> Inserir Locação            |");
              Console.WriteLine("| 2 >>> Listar Clientes            |");
			  Console.WriteLine("| 3 >>> Listar Filmes              |");
			  Console.WriteLine("| 4 >>> Listar Locação             |");
              Console.WriteLine("|--------------------------------|");
			  Console.WriteLine("|********************************|\n");

			//Entrada IdCliente no switch
			Console.WriteLine("\nInforme o ID do CLIENTE: ");
            String entrada = Console.ReadLine();
			idCliente = Convert.ToInt32(entrada);

			switch(idCliente){
				case 1: //adicionar locacao
					break;
				case 2: //listar clientes
					ClienteView.GetClientes();
					break;
				case 3: //listar filmes
					FilmeView.GetFilmes();
					break;
				case 4: //lista locação
					break;

			}
			/*switch (idCliente) {
			case 1:
				ClienteView.getCliente(cliente1); // Impressão CLIENTE "1"
				locacao = new Locacao(01, cliente1); // Nova locações
				filme1.mostrarFilme(); // Impressão dos Filmes
				filme6.mostrarFilme(); //          "
				filme10.mostrarFilme();//          "
				locacao.AdicFilme(filme1); // Adicionando Filme
				locacao.AdicFilme(filme6); //       "
				locacao.AdicFilme(filme10);//       "
				Console.WriteLine("-> PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
				Console.WriteLine("-> DATA DE DEVOLUÇÃO: " + locacao.calculoData());
				Console.WriteLine("-> QTDE TOTAL DE FILMES LOCADOS: " + locacao.QtdeFilmesLoc());
				break;
			} */
		} while (idCliente <= 5);
	}
}
}