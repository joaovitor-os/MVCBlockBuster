using System;
using Models;
using Controllers;

namespace Views{
    public class LocacaoView{
        public int GetLocacoes(){
            int qtd = 0;
		    foreach (Locacao locacao in this.locacoes) {
			    foreach (Filme filme in locacao.filmes) {
				    qtd++;
			    }
		    }
		    return qtd;
        }
    }
}