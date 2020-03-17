using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class FilmeController
    {
        public static void addFilme (int idFilme, string titulo, string dataLancamento, string sinopse, double valorLocacaoFilme, int estoqueFilme) 
            {
                new FilmeModels(idFilme, titulo, dataLancamento, sinopse, valorLocacaoFilme, estoqueFilme);
            }

    public string GetFilme(FilmeModels filme)
        {
            string filmeValue = filme.ToString();

            return filmeValue;
            
            
        }

        public static List<FilmeModels> GetFilmes()
			{
				return FilmeModels.GetFilmes();
			}
        
    }
}