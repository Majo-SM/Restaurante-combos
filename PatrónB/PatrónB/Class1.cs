
// CLASE DIRECTORA: define el orden en el que ejecutar 
 // los pasos de construcción, mientras que el constructor
 //proporciona la implementación de esos pasos.
 

using System;
using System.Collections.Generic;
using System.Text;

namespace PatrónB
{
    class Class1
    {
        //la función Constructor cumplira la función que le hace su honor a su nombre 
        //a su vez se encuentran los métodos que seran parte fundamental para la creación del resultado o produto.
        public void Constructor(CreadorCombo creadorcombo, string bebida, string tamaño, string complemento, string juguete, string name)
        {
            creadorcombo.Combohamburguesa();
            creadorcombo.Combobebida(bebida);
            creadorcombo.Combotamaño(tamaño);
            creadorcombo.Combocomplemento(complemento);
            creadorcombo.Combojuguete(juguete);
            creadorcombo.Comboname(name);
        }                                    
        
    }
}
