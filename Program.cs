using System;
using System.Text.RegularExpressions;
using pantallas1;

namespace mockup
{
    class Program
    {
        static pantallas screen = new pantallas();
        static void Main(string[] args)
        {
            int opc;

            do
            {

                Console.Clear();
                screen.Menu();
                Console.SetCursorPosition(40, 3); Console.Write("Menú");
                Console.SetCursorPosition(40, 6); Console.Write("1. ¿Quiénes somos?");
                Console.SetCursorPosition(40, 8); Console.Write("2. Menu aplicación.");
                Console.SetCursorPosition(40, 10); Console.Write("0. Salir");
                Console.SetCursorPosition(30, 12); Console.Write("Digite una opción: ");

                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        
                        opc1();
                        break;
                    case 2:
                        
                        opc2();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("opción no válida");
                        break;

                }

                Console.ReadKey();

            } while (opc != 0);
        }


    static void opc1()
        {

            Console.Clear();
            screen.pantalla1();
                Console.SetCursorPosition(40, 3); Console.WriteLine("¿Quiénes somos?");
                Console.SetCursorPosition(39, 6); Console.WriteLine("■ Juan David Ducuara Molina");
                Console.SetCursorPosition(39, 8); Console.WriteLine("■ Francisco Alejandro Cifuentes");
                Console.SetCursorPosition(39, 10); Console.WriteLine("■ Diana Sanabria");
                Console.SetCursorPosition(39, 12); Console.WriteLine("■ Daniel Santiago Martínez Carbonell");
                Console.SetCursorPosition(31, 14); Console.Write("Oprima una tecla para volver al menú principal.");
                Console.ReadKey();
                Console.SetCursorPosition(31, 16); Console.Write("Presiona cualquier tecla para continuar");

        }
    static void opc2()
        {

            int opcmenu;

            do
            {
                Console.Clear();
                screen.pantalla2();
                Console.SetCursorPosition(40, 3); Console.WriteLine("Menú aplicación");
                Console.SetCursorPosition(39, 6); Console.WriteLine("1. Agregar personaje");
                Console.SetCursorPosition(39, 8); Console.WriteLine("2. Listar personajes");
                Console.SetCursorPosition(39, 10); Console.WriteLine("3. Buscar personajes");
                Console.SetCursorPosition(39, 12); Console.Write("4. volver al menú principal");
                Console.SetCursorPosition(31, 14); Console.Write("Selecciona una opción: ");

                opcmenu = Convert.ToInt32(Console.ReadLine());

            switch (opcmenu)
            {
                case 1:
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    break;
                case 4:
                        Console.SetCursorPosition(31, 16); Console.WriteLine("Saliendo al menu principal...");
                    break;
                default:
                        Console.SetCursorPosition(31, 16); Console.Write("opción no válida ");
                        break;
            }
            } while (opcmenu != 4);

        }
    }
}
