using System;
using System.Collections.Generic;
using System.Text;

namespace PatrónB
{
    //Se crea la relación necesaria para poder dirigir e ir
    //construyendo cada combo 
    class Solitario : CreadorCombo
    {
        //aqui con la ayuda del campo dictionary se podra construir e ir asignando
        // las distintas complementarias para el combo
        public Solitario()
        {
            creador = new Creador(" *** COMBO *** ");

        }
        //Implementación de los atributos ya planteados y aquellos que el usuario elige

        //se encuentra ya planetado
        public override void Combohamburguesa()
        {
            creador["hamburguesa"] = "Una Hamburguesa extra carne";
        }
        //lo elije el usuario 
        public override void Combobebida(string bebida)
        {
            creador["bebida"] = bebida;
        }
        //lo elije el usuario 
        public override void Combotamaño(string tamaño)
        {
            creador["tamaño"] = tamaño;
        }
        //lo elije el usuario 
        public override void Combocomplemento(string complemento)
        {
            creador["complemento"] = complemento;
        }
        //lo elije el usuario 
        public override void Combojuguete(string juguete)
        {
            creador["juguete"] = juguete;
        }
        //lo elije el usuario 
        public override void Comboname(string name)
        {
            creador["nombre"] = name;
        }
    }
        

    
}
