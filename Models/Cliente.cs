using System;
using System.Collections.Generic;
using Repositories;

namespace Models{
    public class Cliente{
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Dt_Nasc { get; set; }
        public string CPF { get; set; }
        public int Dias_pdevolucao { get; set; }
        public int FilmesLocados { get; set; }

        public Cliente (int id, string nome, string dt_nasc, string cpf, int dias_pdevolucao){
            ID = id;
            Nome = nome;
            Dt_Nasc = dt_nasc;
            CPF = cpf;
            Dias_pdevolucao = dias_pdevolucao;
            ClienteRepos.AddCliente(this);
        }
        public static List<Cliente> Clientes () {
            return ClienteRepos.Clientes();
        }

        public override string ToString(){
            return $"{ID} - {Nome}";
        }
    }
}