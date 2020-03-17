using System;
using Views;

namespace MVCLocadora{
    public class ArqPrincipal{
        public static void Main(string[] args){
            ClienteView.GetClientes();
            FilmeView.GetFilmes();
            LocacaoView.GetLocacoes();
        }
    }
}