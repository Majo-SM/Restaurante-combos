/* 
 * Santana Minaya María José 
 * --Tercero A--
 * Ejemplo del uso del patrón Builder/Constructor en el cual se crea los distintos complementos
 * que desea el cliente obtener en el combo que el desee. */

using System;

namespace PatrónB
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            int n;
            string respuestas = "si";
            //estructura repetitiva que permitira 
            //conocer si desea hacer un nuevo combo 
            
            while (respuestas.Equals("si"))
            {
                //Menú para la eleccion del combo alimentició
                Console.WriteLine(" ===== Bienvenido al menú ====");
                Console.WriteLine("***********************************");
                Console.WriteLine("==Elija el tipo de combo que desea==");
                Console.WriteLine("* Combo infantil.... 1 *");
                Console.WriteLine("* Combo familiar.... 2 *");
                Console.WriteLine("* Combo  amigos ..... 3 *");
                Console.WriteLine("* Solo para una persona...4 *");
                Console.WriteLine("***********************************");
                Console.WriteLine("Digite el número del combo que desea....");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                //planteamiento de los distintos combos
                switch (n)
                {
                    case 1:
                        Console.WriteLine("A seleccionado el Combo infantil..." + n +
                            "...");

                        break;
                    case 2:
                        Console.WriteLine("A seleccionado el Combo familiar..." + n +
                           "...");
                        break;
                    case 3:
                        Console.WriteLine("A seleccionado el Combo para Amigos..." + n +
                           "...");
                        break;
                    case 4:
                        Console.WriteLine("A seleccionado el Combo para una persona..." + n +
                           "..");
                        break;
                }

                switch (n)
                {
                    case 1:
                        ComboInfantil();
                        break;
                    case 2:
                        ComboFamiliar();
                        break;
                    case 3:
                        Comboparaamig();
                        break;
                    case 4:
                        Solitario();
                        break;
                }
                do
                {
                    Console.WriteLine("...¿Desea usted crear otro combo?...Digite si o no");
                    respuestas = Console.ReadLine();
                } while (!(respuestas.Equals("si"))&& !(respuestas.Equals("no")));
            }
            Console.WriteLine("Para salir presione enter dos veces");
            Console.ReadKey();
        }

        //Metodo para la realización del combo
        public static void ComboInfantil()
        {
            //Se crea el objeto DIRECTOR 
            Class1 class1 = new Class1();

            CreadorCombo creador = new ComboFamiliar();
            string bebida, tamaño, complemento, juguete, nombre;
            bebida = Bebida();
            tamaño = TamañoB();
            complemento = Aderezo();
            juguete = Sorpresa();
            nombre = Cliente();

            Console.WriteLine("Su combo Infantil fue procesado!");
            class1.Constructor(creador,bebida,tamaño,complemento,juguete,nombre);

            creador.Creador.Revisar();

        }
        //Metodo para la realización del combo
        public static void ComboFamiliar()
        {
            Class1 class1 = new Class1();

            CreadorCombo creador = new ComboFamiliar();
            string bebida, tamaño, complemento, juguete, nombre;
            bebida = Bebida();
            tamaño = TamañoB();
            complemento = Aderezo();
            juguete = Sorpresa();
            nombre = Cliente();

            Console.WriteLine("Su combo Familiar fue procesado!");
            class1.Constructor(creador, bebida, tamaño, complemento, juguete, nombre);

            creador.Creador.Revisar();
        }
        //Metodo para la realización del combo
        public static void Comboparaamig()
        {
            Class1 class1 = new Class1();

            CreadorCombo creador = new ComboFamiliar();
            string bebida, tamaño, complemento, juguete, nombre;
            bebida = Bebida();
            tamaño = TamañoB();
            complemento = Aderezo();
            juguete = Sorpresa();
            nombre = Cliente();

            Console.WriteLine("Su combo para amigos fue procesado!");

            class1.Constructor(creador, bebida, tamaño, complemento, juguete, nombre);

            creador.Creador.Revisar();
        }
        //Metodo para la realización del combo
        public static void Solitario()
        {
            Class1 class1 = new Class1();

            CreadorCombo creador = new ComboFamiliar();
            string bebida, tamaño, complemento, juguete, nombre;
            bebida = Bebida();
            tamaño = TamañoB();
            complemento = Aderezo();
            juguete = Sorpresa();
            nombre = Cliente();

            Console.WriteLine("Su combo personal para una fue procesado!");
            class1.Constructor(creador, bebida, tamaño, complemento, juguete, nombre);

            creador.Creador.Revisar();
        }
        //Metodo para la realización del combo
        public static string Bebida()
        {
            string bebida;
            Console.WriteLine("Escoja la bebida que desea");
            Console.WriteLine("...1=Café-\t-...2=Jugo Natural-\t-...3=Gaseosa");
            Console.WriteLine("Digite el número de acuerdo a la bebida que desea");
            bebida = Console.ReadLine();

            switch (bebida)
            {
                case "1":
                    bebida = "Café";
                    break;
                case "2":
                    bebida = "Jugo Natural";
                    break;
                case "3":
                    bebida = "Gaseosa";
                    break;
            }
            return bebida;

        }
        //Metodo para la realización del combo
        public static string TamañoB()
        {
            string tamaño;
            Console.WriteLine("Escoja el tamaño de la bebida que desea");
            Console.WriteLine("1=Grande-\t-2=Mediano-\t-3=Pequeño");
            Console.WriteLine("Digite el número de acuerdo al tamaño de la bebida que desea");
            tamaño = Console.ReadLine();

            switch (tamaño)
            {
                case "1":
                    tamaño = "Grande";
                    break;
                case "2":
                    tamaño = "Mediano";
                    break;
                case "3":
                    tamaño = "Pequeño";
                    break;
            }
            return tamaño;


        }
        //Metodo para la realización del combo
        public static string Aderezo()
        {
            string complemento;

            Console.WriteLine("Escoja el tipo de complemento que desea");
            Console.WriteLine("1=Nuggets-\t-2=papas fritas-\t-3=Ensalada");
            Console.WriteLine("Digite el número de acuerdo al tamaño de la bebida que desea");
            complemento  = Console.ReadLine();

            switch (complemento)
            {
                case "1": 
                    complemento = "Nuggets";
                    break;
                case "2":
                    complemento = "papas fritas";
                    break;
                case "3":
                    complemento = "Ensalada";
                    break;
            }
            return complemento;
        }
        //Metodo para la realización del combo
        public static string Sorpresa()
        {
            string juguete;
            Console.WriteLine("Escoja la sorpresa de su combo");
            Console.WriteLine("1=Más papas-\t-2=Bebida extra -\t-3=Juguete armable");
            Console.WriteLine("Digite el número de acuerdo al tamaño de la bebida que desea");
            juguete = Console.ReadLine();

            switch (juguete)
            {
                case "1":
                    juguete = "Más papas";
                    break;
                case "2":
                    juguete = "Bebida extra";
                    break;
                case "3":
                    juguete = "Juguete armable";
                    break;
            }
            return juguete;
        }
        //Metodo para la realización del combo
        public static string Cliente()
        {
            string nombre;
            Console.WriteLine("***Digite el nombre de quien es el Combo***");
            nombre = Console.ReadLine();
            Console.WriteLine();
            return nombre;
        }



    }
}
