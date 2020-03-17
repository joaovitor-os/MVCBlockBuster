using System;
using Models;
using Controllers;

namespace Views{
    public class FilmeView{
        public static void GetFilmes(){
            LocacaoController.AddFilme(11111,"Coringa","2019","Drama",4.99,5);
            LocacaoController.AddFilme(22222,"Vingadores: Ultimato","2019","Ação",4.99,5);
            LocacaoController.AddFilme(11122,"Rocky III","1982","drama",3.50,3);
            LocacaoController.AddFilme(11133,"Creed","2015","drama",4.20,4);
            LocacaoController.AddFilme(33333,"O lobo de wall street","2013","drama/comédia",3.99,2);
            LocacaoController.AddFilme(22233,"Batman: O Cavaleiro das Trevas","2008","ação",3.50,3);
            LocacaoController.AddFilme(44444,"De Volta para o Futuro","1985","ficção cinentifica",3.99,3);
            LocacaoController.AddFilme(44455,"Star Wars: Uma Nova Esperança","1977","ficção cientifica",3.99,3);
            LocacaoController.AddFilme(55555,"Toy Story","1995","animação",3.99,3);
            LocacaoController.AddFilme(11144,"Clube da Luta","1996","drama",2.99,2);
            foreach (Filme filme in LocacaoController.Filmes())
            {
                Console.WriteLine(filme);   
            }
        }
    }
}