using System;
using Models;
using Controllers;
using System.Collections.Generic;

namespace View
{
    public class LocacaoView
    {
        public static void ImprimirLocacao()
        {     
            List<LocacaoModels> locacoes = LocacaoController.GetLocacaoModels();

            locacoes.ForEach(locacao => Console.WriteLine(locacao));
        }

        public static void AdicionarLocacao()
        {
            List<ClienteModels> clientes = ClienteController.GetClientes();
            List<FilmeModels> filmes = FilmeController.GetFilmes();
            
            
            int idCliente = 0;
           
            Console.WriteLine("\nDigite o ID Cliente:");
            idCliente = Convert.ToInt32(Console.ReadLine());

            if (idCliente <= 5) 
            { 
                ClienteModels cliente = clientes.Find(cliente => cliente.IdCliente == idCliente);

                LocacaoModels locacao = LocacaoController.addLocacao(1, cliente);
            
                int idFilme = 0;                           
                do
                {
                    Console.WriteLine("\nDigite o ID Filme: ");
                    Console.WriteLine("DIGITE ZERO P/ FINALIZAR!");
                    idFilme = Convert.ToInt32(Console.ReadLine());

                    if (idFilme != 0)
                    {
                        FilmeModels filme = filmes.Find(filme => filme.IdFilme == idFilme);

                        locacao.AdicionarFilme(filme);
                    }
                } while (idFilme != 0);  
            }                  
        }
    }
}