using System;
using System.Collections.Generic;
using Repositories;

namespace Models{
    public class Filme{
        public int ID_Filme { get; set; }
        public String Nome_Filme { get; set; }
        public String Dt_lancamento { get; set; }
        public String Sinopse { get; set; }
        public double Valor_locacao { get; set; }
        public int Estoque { get; set; }
        public int Locado  { get; set; }

        public Filme (int id_filme, string nome_filme, string dt_lancamento, string sinopse, double valor_locacao, int estoque){
            ID_Filme = id_filme;
            Nome_Filme = nome_filme;
            Dt_lancamento = dt_lancamento;
            Sinopse = sinopse;
            Valor_locacao = valor_locacao;
            Estoque = estoque;
            Locado = 0;
            FilmeRepos.AddFilme(this);
        }
        public static  List<Filme> Filmes () {
            return FilmeRepos.Filmes();
        }
    }
}