using System;
using Models;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;


namespace NameLocacao {

public class Locacao {
	// Atributos
	public int idLoc { get; set; }
	public Cliente cliente { get; set; }
	public String dataLoc { get; set; }
	public String dataDevolucao { get; set; }
	public Double valorTotal { get; set; }

	public List<Filme> filmes = new List<Filme>();
	// Construtor
	public Locacao(int idLoc, Cliente cliente) {

		this.idLoc = idLoc;
		this.cliente = cliente;

		this.cliente.adicionarLocacao(this);
	}

	// Adição de Filmes
	public void AdicFilme(Filme filme) {
		this.filmes.Add(filme);
	}

	// Método com o Valor Total das Locações (Preço)
	public double PrecoTotal() {
		double total = 0;
		foreach (Filme filme in filmes) {
			total += filme.valorLoc;
		}
		return total;
	}

	// Método com a Quantidade de Filmes Locados
	public int QtdeFilmesLoc() {
		return this.filmes.Count;
	}

	// Calculo Data de Devolução
	public String calculoData() {
		DateTime dataAtual = DateTime.Now;

		return dataAtual.AddDays(cliente.diaDev).ToString("dddd, dd MMMM yyyy");
	}
}
}