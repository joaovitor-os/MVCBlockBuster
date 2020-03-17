using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers{
    public class ClienteController : Controller {
        public static List<Cliente> Clientes(){
            return Cliente.Clientes();
        }

        public static void AddCliente(int id, string nome, string dt_nasc, string cpf, int dias_pdevolucao){
            new Cliente(id, nome, dt_nasc, cpf, dias_pdevolucao);
        }
//MÉTODO MOSTRANDO A  QUANTIDADE DE FILMES LOCADOS
        public int QtdFimesCliente(int filmeslocados) {
		return this.filmeslocados = filmeslocados;
	    }
//ADICIONANDO AS LOCAÇÕES DOS FILMES
        public void adicionarLocacao(Locacao locacao) {
		    this.locacoes.Add(locacao);
	    }
    }
}