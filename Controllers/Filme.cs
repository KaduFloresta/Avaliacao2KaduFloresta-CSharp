using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class FilmeController
    {
        public static void addFilme(int idFilme, string titulo, string dataLanc, string sinopse, double valorLoc, int estoque)  
            {
                new Filme(idFilme, titulo, dataLanc, sinopse, valorLoc, estoque);
            }

        public static List<Filme> GetFilmes()
			{
				return Filme.GetFilmes();
			}
        
    }
}