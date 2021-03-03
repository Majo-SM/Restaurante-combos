using System;
using System.Collections.Generic;
using System.Text;

namespace PatrónB
{
    //Se crea la relación necesaria para poder dirigir e ir
    //construyendo cada combo
    class ComboFamiliar : CreadorCombo
    {
        //aqui con la ayuda del campo dictionary se podra construir e ir asignando
        // las distintas complementarias para el combo
        public ComboFamiliar()
        {
            creador = new Creador(" *** COMBO *** ");

        }
        //Implementación de los atributos ya planteados y aquellos que el usuario elige
        //se encuentra ya planetado
        public override void Combohamburguesa()
        {
            creador["hamburguesa"] = " Hamburguesas con carne y queso";
        }
        //el usuario elije  
        public override void Combobebida(string bebida)
        {
            creador["bebida"] = bebida;
        }
        //el usuario elije 
        public override void Combotamaño(string tamaño)
        {
            creador["tamaño"] = tamaño;
        }
        //el usuario elije 

        public override void Combocomplemento(string complemento)
        {
            creador["complemento"] = complemento;
        }
        //el usuario elije 
        public override void Combojuguete(string juguete)
        {
            creador["juguete"] = juguete;
        }
        //el usuario elije 
        public override void Comboname(string name)
        {
            creador["nombre"] = name;

        }
    }
}
