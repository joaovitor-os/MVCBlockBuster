using System;
using System.Collections.Generic;
using Repositories;

namespace Models{
    public class Locacao{
        public int Id_locacao = 0;
        public Cliente cliente;
        public string Dt_locacao { get; set; }
        public string Dt_devolucao { get; set; }
        public double Vlr_total { get; set; }

        public Locacao ( int id_locacao, Cliente cliente){
            Id_locacao = id_locacao;
            this.cliente = cliente;
            LocacaoRepos.AddLocacao(this);
        }
        public static List<Locacao> Locacoes () {
            return LocacaoRepos.Locacoes();
        }
    }
}