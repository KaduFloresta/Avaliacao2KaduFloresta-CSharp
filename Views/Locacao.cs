using System;
using System.Collections.Generic;
using Models;
using Controllers;

namespace View
{
    public class LocacaoView
    {
        public static void ImprimirLocacao()
        {            
            Console.WriteLine("\n------------------===[ Dados do Cliente ]===------------------");

            Console.WriteLine("\n-------------------===[ Filmes Locados ]===-------------------");            

            List<LocacaoModels> locacoes = LocacaoController.GetLocacaoModels();

            locacoes.ForEach(locacao => Console.WriteLine(locacao));
        }

        public static void AdicionarLocacao()
        {
            List<ClienteModels> clientes = ClienteController.GetClientes();
            List<FilmeModels> filmes = FilmeController.GetFilmes();

            Console.WriteLine("\nDigite o ID Cliente:");
            int idCliente = Convert.ToInt32(Console.ReadLine());

            ClienteModels cliente = clientes.Find(cliente => cliente.IdCliente == idCliente);

            LocacaoModels locacao = LocacaoController.addLocacao(1, cliente);

            int idFilme = 0;
            do
            {
                Console.WriteLine("\nDigite o ID Filme: ");
                Console.WriteLine("DIGITE ZERO P/ SAIR!");
                idFilme = Convert.ToInt32(Console.ReadLine());

                if(idFilme != 0)
                {
                    FilmeModels filme = filmes.Find(filme => filme.IdFilme == idFilme);

                    locacao.AdicionarFilme(filme);
                }
            } while(idFilme != 0);                    
        }
    }
}