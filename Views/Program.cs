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
              Console.WriteLine("|-------------MENU---------------|"); 
              Console.WriteLine("| 1 - Inserir Locação            |");
              Console.WriteLine("| 2 - Listar Clientes            |");
			  Console.WriteLine("| 3 - Listar Filmes              |");
			  Console.WriteLine("| 4 - Listar Locação             |");
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
			case 2:
				Console.Write(cliente2);
				locacao = new Locacao(02, cliente2);
				filme2.mostrarFilme();
				filme7.mostrarFilme();
				locacao.AdicFilme(filme2);
				locacao.AdicFilme(filme7);
				Console.WriteLine("-> PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
				Console.WriteLine("-> DATA DE DEVOLUÇÃO: " + locacao.calculoData());
				Console.WriteLine("-> QTDE TOTAL DE FILMES LOCADOS: " + locacao.QtdeFilmesLoc());
				break;
			case 3:
				Console.Write(cliente3);
				locacao = new Locacao(03, cliente3);
				filme3.mostrarFilme();
				filme6.mostrarFilme();
				filme7.mostrarFilme();
				filme8.mostrarFilme();
				locacao.AdicFilme(filme3);
				locacao.AdicFilme(filme6);
				locacao.AdicFilme(filme7);
				locacao.AdicFilme(filme8);
				Console.WriteLine("-> PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
				Console.WriteLine("-> DATA DE DEVOLUÇÃO: " + locacao.calculoData());
				Console.WriteLine("-> QTDE TOTAL DE FILMES LOCADOS: " + locacao.QtdeFilmesLoc());
				break;
			case 4:
				Console.Write(cliente4);
				locacao = new Locacao(04, cliente1);
				filme4.mostrarFilme();
				filme9.mostrarFilme();
				locacao.AdicFilme(filme4);
				locacao.AdicFilme(filme9);
				Console.WriteLine("-> PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
				Console.WriteLine("-> DATA DE DEVOLUÇÃO: " + locacao.calculoData());
				Console.WriteLine("-> QTDE TOTAL DE FILMES LOCADOS: " + locacao.QtdeFilmesLoc());
				break;
			case 5:
				Console.Write(cliente5);
				locacao = new Locacao(05, cliente1);
				filme1.mostrarFilme();
				filme5.mostrarFilme();
				filme10.mostrarFilme();
				locacao.AdicFilme(filme1);
				locacao.AdicFilme(filme5);
				locacao.AdicFilme(filme10);
				Console.WriteLine("-> PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
				Console.WriteLine("-> DATA DE DEVOLUÇÃO: " + locacao.calculoData());
				Console.WriteLine("-> QTDE TOTAL DE FILMES LOCADOS: " + locacao.QtdeFilmesLoc());
				break;
			} */
		} while (idCliente <= 5);
	}
}
}