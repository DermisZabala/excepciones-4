using System;
using System.Linq.Expressions;

namespace excepciones4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int mesAño = 0;
            bool intentar = false;                       
            
            while (!intentar) 
            { 
                try
                {
                    Console.WriteLine("\nIngrese el numero de un mes");
                    mesAño = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(MesDelAño(mesAño));
                    intentar = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Haz cometido un error de tipo: " + ex.Message);

                    Console.WriteLine("Vuelva a intentarlo");

                }
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("Presione la tecla espacio para seguir \nPresione cualquier otra tecla para salir");
                Console.WriteLine("-----------------------------------------------------------------");
                ConsoleKeyInfo salir = Console.ReadKey();
                if (salir.Key == ConsoleKey.Spacebar)
                {
                    intentar = true;
                }
                else
                {
                    intentar = false;
                }

            }
            Console.ReadKey();
        }

        public static string MesDelAño(int mes)
        {
            switch(mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    throw new ArgumentOutOfRangeException();

            }
        }
    }
}
