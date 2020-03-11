using System;
using NameLocacao;
using System.Collections.Generic;

namespace Models {

	public class Cliente {
		// Atributos
		public int idCliente { get; set; }
		public String nome { get; set; }
		public String dataNasc { get; set; }
		public String cpf { get; set; }
		public int diaDev { get; set; }
		public List<Locacao> locacoes = new List<Locacao>();

		// Construtor
		public Cliente(int idCliente, string nome, string dataNasc, string cpf, int diaDev) {
			// Atributos
			this.idCliente = idCliente;
			this.nome = nome;
			this.dataNasc = dataNasc;
			this.cpf = cpf;
			this.diaDev = diaDev;
		}

		// Método com a Quantidade de Filmes locados
		public int QtdeFimesLocCliente() {
			return locacoes.Count;
		}

		// Impressão Dados do CLiente
		public override string ToString() {
			return  $"----------------CLIENTE----------------\n" +
					$"--> Nº ID DO CLIENTE: {idCliente}\n" +
					$"-> NOME COMPLETO: {nome}\n" +
					$"-> DATA DE NASCIMENTO: {dataNasc}\n" +
					$"-> CPF: {cpf}\n" +
					$"-> DIAS P/ DEVOLUÇÃO: {diaDev}\n";
		}
		// Adição de Locações
		public void adicionarLocacao(Locacao locacao) {
			this.locacoes.Add(locacao);
		}

		public static List<Cliente> GetClientes(){
			return Repositories.RepositoriesCliente.clientes;
		}

	}
}
