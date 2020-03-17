using System;
using Models;
using Controllers;

namespace Views{
    public class ClienteView{
        public static void GetClientes(){
            ClienteController.AddCliente(1,"Gionisio","23/03/1977","111.111111-11",3);
            ClienteController.AddCliente(2,"Frederico","02/06/1981","222.222.222-22",3);
            ClienteController.AddCliente(3,"Jubileu","17/08/1969","333.333.333-33",3);
            ClienteController.AddCliente(4,"Florentina","14/13/1972","444.444.444-44",3);
            ClienteController.AddCliente(5,"Antonieta","27/11/1983","555.555.555-55",3);
            foreach (Cliente cliente in ClienteController.Clientes())
            {
                Console.WriteLine(cliente);   
            }
        }
    }
}