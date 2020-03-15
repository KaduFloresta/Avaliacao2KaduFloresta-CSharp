using System;
using System.Collections.Generic;

namespace Models 
{
	public class LocacaoModels 
	{
		// Atributos
		public int IdLocacao { get; set; }
		public ClienteModels Cliente { get; set; }
		public string DataLocacao { get; set; }
		public string DataDevolucao { get; set; }
		public double ValorTotal { get; set; }
		public DateTime Data = DateTime.Today;

		public List<FilmeModels> filmes = new List<FilmeModels>();

		// Construtor
		public LocacaoModels (int idLocacao, ClienteModels cliente) 
			{
				IdLocacao = idLocacao;
				Cliente = cliente;
				DataLocacao = Data.ToString().Substring(0,10);
			}

		// Adição de Filmes
		public void AdicionarFilme(FilmeModels filme) 
			{
				if (filme.EstoqueFilme>1)
				{
					filmes.Add(filme);
					//ClienteModels.FilmeLocado += 1;
				}
				else
				{
					Console.WriteLine($"Não é Possível Locar esse Filme!");
				}
			}

		// Método com o Valor Total das Locações (Preço)
		public void PrecoTotalLocaçoes() 
			{
				foreach (FilmeModels filme in filmes) 
					{
						ValorTotal += filme.ValorLocacaoFilme;
					}
			}

		// Calculo Data de Devolução
		public void calculoDataDevolucao() 
		{
			//Data.AddDays(ClienteModels.Dias);
			DataDevolucao = Data.ToString().Substring(0,10);
		}

		public override string ToString() 
			{
				return  $"-> PREÇO TOTAL DAS LOCAÇÕES: R$ {ValorTotal}\n" +
						$"-> DATA DE DEVOLUÇÃO: {DataDevolucao}\n" +
						$"-> QTDE TOTAL DE FILMES LOCADOS: \n";
						
			}			
	}
}