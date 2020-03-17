using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers{
    public class FilmeController : Controller {
        public static List<Filme> Filmes(){
            return Filme.Filmes();
        }
//MÉTODO MONSTRANDO A QUANTIDADE DE LOCAÇÕES
        public void filmeLocado(){
            Estoque -=1;
            Locado +=1;
        }
    }
}