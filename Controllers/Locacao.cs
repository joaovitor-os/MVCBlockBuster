using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers{
    public class LocacaoController : Controller{
        public static List<Filme> Filmes(){
            return Filme.Filmes();
        }
//ADICIONADO OS FILMES
        public static void AddFilme(int id_filme, string nome_filme, string dt_lancamento, string sinopse, double valor_locacao, int estoque){
            new Filme(id_filme, nome_filme, dt_lancamento, sinopse, valor_locacao, estoque);
        }
//MÉTODO MONSTRANDO O VALOR TOTAL DAS LOCAÇÕES
        public double preco_locacoes() {
		    double total = 0;
		    foreach (Filme filme in Filme) {
			    total += filme.Valor_locacao;
		    }
		    return total;
	    }
//MÉTODO MONSTRANDO A QUANTIDADE DE FILMES LOCADOS
        public int qtd_filmeslocados() {
		    return this.Filmes.Count;
	    }
//CALCULO PARA MOSTRAR A DATA DE DEVOLUÇÃO
        public String calculo_dtdevolucao() {
		    DateTime dataAtual = DateTime.Now;
		    return dataAtual.AddDays(Cliente.dias_pdevolucao).ToString("dddd, dd MMMM yyyy");
	    }
    }
}