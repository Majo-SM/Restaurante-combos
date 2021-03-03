//Clase constructora
//INTERFACE-CONSTRUCTOR
//

using System;
using System.Collections.Generic;
using System.Text;

namespace PatrónB
{
    //se hace la respectiva creación de la clase abstracta 
    abstract class CreadorCombo
    {
        //Se crea el producto que se usara en cada clase hija
        protected Creador creador;
        //
        public Creador Creador
        {
            //get se ejecuta cuando se lee la propiedad.
            get
            {
                return creador;
            }
        }
        //Implementamos o ubicamos los métodos que se necesitan los cuales nos permitirán 
        //crear los atribujos para el objeto producto (Creador) y asi las clases hereden de ésta
        public abstract void Combohamburguesa();
        public abstract void Combobebida(string bebida);
        public abstract void Combotamaño(string tamaño);
        public abstract void Combocomplemento(string complemento);
        public abstract void Combojuguete(string juguete);
        public abstract void Comboname(string name);
    }
      
    
}


               
                
    