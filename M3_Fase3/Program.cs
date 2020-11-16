using System;



namespace M3_Fase3
{
    class Program
    {


        static void Main(string[] args)
        {
            //creamos los strings vacíos

            string city1 = "";
            string city2 = "";
            string city3 = "";
            string city4 = " ";
            string city5 = " ";
            string city6 = " ";



            //Introducimos los datos por teclado tras la petición del programa, los guardamos en sus strings


            Console.WriteLine(" Escribe un nombre de ciudad española: ");
            city1 = Console.ReadLine();
            Console.WriteLine(" Escribe un nombre de ciudad española: ");
            city2 = Console.ReadLine();
            Console.WriteLine(" Escribe un nombre de ciudad española: ");
            city3 = Console.ReadLine();
            Console.WriteLine(" Escribe un nombre de ciudad española: ");
            city4 = Console.ReadLine();
            Console.WriteLine(" Escribe un nombre de ciudad española: ");
            city5 = Console.ReadLine();
            Console.WriteLine(" Escribe un nombre de ciudad española: ");
            city6 = Console.ReadLine();


            string[] citys = new string[6];

            Console.WriteLine("Listado de Ciudades" + "\n");
            //Introducimos los nombres de las ciudades que hemos ido tecleando en el array citys

            citys[0] = city1; Console.WriteLine(citys[0]);
            citys[1] = city2; Console.WriteLine(citys[1]);
            citys[2] = city3; Console.WriteLine(citys[2]);
            citys[3] = city4; Console.WriteLine(citys[3]);
            citys[4] = city5; Console.WriteLine(citys[4]);
            citys[5] = city6; Console.WriteLine(citys[5]);
            Console.WriteLine("\n");
            string[] modifiedCitys = new string[6];


            for (int i = 0; i < modifiedCitys.Length; i++)  //Recorre todo el array citys una vez que entra dentro del bucle va cambiando las "a" por "4"
            {
                modifiedCitys[i] = citys[i].Replace("a", "4");
            }


            //FASE 2
            Array.Sort(modifiedCitys); //Ordena los nombres de ciudades 
            Console.WriteLine("Ciudades Ordenadas: y con caracter a cambiado por 4" + "\n");
            for (int i = 0; i <= 6; i++)  //Recorre todo el array citys 
            {
                Console.WriteLine(modifiedCitys[i]);
            }


           



        }


    }
}

