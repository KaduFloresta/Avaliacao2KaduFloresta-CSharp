using System;

namespace ModelFilme {

public class Filme {
    // Atributos
    public int idFilme { get; set; }
    public String titulo { get; set; }
    public String dataLanc { get; set; }
    public String sinopse { get; set; }
    public Double valorLoc { get; set; }
    public int estoque { get; set; }
    public int locado { get; set; }

    // Construtor
    public Filme(int idFilme, String titulo, String dataLanc, String sinopse, Double valorLoc, int estoque) {
        this.idFilme = idFilme;
        this.titulo = titulo;
        this.dataLanc = dataLanc;
        this.sinopse = sinopse;
        this.valorLoc = valorLoc;
        this.estoque = estoque;
        this.locado = 0;
    }

    // Método com a Quantidade de locações Realizadas
    public void filmeLocado() {
        this.estoque -= 1;
        this.locado += 1;
    }

    // Impressão Dados do Filme
    public override string ToString() {
        return  $"----------------------------FILME----------------------------------------------------------------------------------------------------------\n\n" +
                $"--> Nº ID DO FILME: \n" + 
                $"-> TÍTULO: \n" + 
                $"-> DATA DE LANÇAMENTO: \n" + 
                $"-> SINOPSE: \n" + 
                $"-> VALOR DA LOCAÇÃO: R$ \n" + 
                $"-> QTDE EM ESTOQUE: \n" + 
                $"-> QTDE DE LOCAÇÕES REALIZADAS: \n" + 
                $"-------------------------------------------------------------------------------------------------------------------------------------------";
    }
}
}