using System;
using System.Collections.Generic;
using Models;

namespace Repositories {
    public static class LocacaoRepos {
        private static readonly List<Locacao> locacoes = new List<Models.Locacao>();

        public static List<Locacao> Locacoes(){
            return locacoes;
        }

        public static void AddLocacao(Locacao locacao){
            locacoes.Add(locacao);
        }
    }
}