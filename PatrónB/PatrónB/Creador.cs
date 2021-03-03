//Creación de la clase considerada
//PRODUCTO
//

using System;
using System.Collections.Generic;
using System.Text;

namespace PatrónB
{
    class Creador
    {
        
        //declaración de la variable tipo string 
        private string creadorT;
        //Se crea el objeto necesario para guardar o acumular la información y 
        //asi ir constryendo 
        private Dictionary<string, string> dictionary =
          new Dictionary<string, string>();
        public Creador(string creadorT)
        { 
            this.creadorT = creadorT;
        } 
        

        //Esta sección permitirá que desde la clase hija en donde se procede a asignarle
        //valores a los arreglos 
        public string this [string key]
        {
            get
            {
                return dictionary[key];
            }
            set
            {
                dictionary[key] = value;

            }
        }

       //Este metódo nos permité revisar y permitira 
       //mostrar como se dará nuestro menú.

        public void Revisar()
        {

            Console.WriteLine("**********************************************************");
            Console.WriteLine(" {0}", creadorT);
            Console.WriteLine("***HAMBURGUESA: {0}", dictionary ["hamburguesa"]);
            Console.WriteLine("***BEBIDA: {0}", dictionary["bebida"]);
            Console.WriteLine("***TAMAÑO DE LA BEBIDA: {0}", dictionary["tamaño"]);
            Console.WriteLine("***COMPLEMENTO: {0}", dictionary["complemento"]);
            Console.WriteLine("***EXTRA: {0}", dictionary["juguete"]);
            Console.WriteLine("***DUEÑO DE LA ORDEN: {0}", dictionary["nombre"]);
            Console.WriteLine("*****GRACIAS POR SU COMPRA*****");
            Console.ReadKey();
        }
    }
}
