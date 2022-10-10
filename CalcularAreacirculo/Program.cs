using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreacirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practica1();
            Practica2();
        }

        #region Practica1     
        static void Practica1()
        {
            //Console.WriteLine("¡Hola mundo!");

            ///int edad = 25;
            //int alumnos = 24;
            //string curso = "DEINT";

            //Console.WriteLine("Tu edad es de " + edad + " años");
            //Console. WriteLine ($"Ти edad es de {edad} años");
            // Console. WriteLine ("Tu edad es de {0}", edad); 
            //Console.WriteLine("En la clase de {0} hay {1} alumnos", curso, alumnos);

            Console.WriteLine("Introduce un valor para el radio");
            int radio = int.Parse(Console.ReadLine());
            const double PI = 3.14;

            double area = PI * Math.Pow(radio, 2);

            Console.WriteLine($"Tu area del circulo de radio {radio} es {area}");
        }
        #endregion

        #region Practica2
        static void Practica2()
        {
            Console.WriteLine("¿Cuantos años tienes?");
            int edad = int.Parse(Console.ReadLine());


            if (edad <= 18)
            {
                Console.WriteLine("No puedes conducir");
            }
            if (edad >= 18)
            {
                Console.WriteLine("¿Tienes carnet de conducir?(S/N)");

                string respuesta = Console.ReadLine();
                if (respuesta.Equals("S"))
                {

                    Console.WriteLine("Puedes conducir");
                } else {
                    Console.WriteLine("No puedes conducir");
                        }
            }


        }



        #endregion
    }
}
