using System;

namespace PracticaClase2_2
{
    class Program
    {
        public static string[] arregloPlatillos = new string[10];
        public static string[] arregloPrecios = new string[10];
        public static string[,] platillosSeleccionados = new string[3,3];

        static void Main(string[] args)
        {
            string opcionSeleccionda = "";            

            while (!opcionSeleccionda.Equals("3")) {
                menu();
                opcionSeleccionda = Console.ReadLine();

                switch (opcionSeleccionda) { 
                    case "1":
                        cargarOpcionesMenu();
                        break;
                    case "2":
                        compraAlimentosCliente();
                        break;
                }
            }
        }

        public static void cargarOpcionesMenu() {
            Console.WriteLine("Esta es la opción de Carga de Menú");
            Console.WriteLine("Indique la posición en la que desea registrar el Platillo Nuevo \n " +
                "[Valor desde 1 al 10]");
            Console.Write("Posición deseada: ");
            int posicionIndice = int.Parse(Console.ReadLine())-1;

            //Se pide el nombre del platillo
            Console.Write("Digite el nombre del platillo: ");
            arregloPlatillos[posicionIndice] = Console.ReadLine();
            //Se pide el precio del platillo
            Console.Write("Digite el precio del platillo: ");
            arregloPrecios[posicionIndice] = Console.ReadLine();

            Console.WriteLine("************************************");
            Console.WriteLine("Platillo agregado: " + arregloPlatillos[posicionIndice]);
            Console.WriteLine("Precio registrado: " + arregloPrecios[posicionIndice]);

            Console.WriteLine("\nPresione ENTER para continuar.....");
            Console.ReadKey();
            
        }


        public static void compraAlimentosCliente()
        {   //1. Desplegar el menu
            Console.WriteLine("El menú existente es: ");
            Console.WriteLine("CODIGO      PLATILLO       PRECIO");
            for (int i = 0; i < arregloPlatillos.Length; i++)                
            {
                int indice = i + 1;
                Console.WriteLine( indice + "   " + arregloPlatillos[i] + "   ¢" + arregloPrecios[i]);
            }
            Console.WriteLine("************************");

            //Cliente selecciona los platillos
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Selecciones el código del platillo deseado: ");
                int indiceSeleccionado = int.Parse(Console.ReadLine());
                indiceSeleccionado = indiceSeleccionado - 1;

                platillosSeleccionados[i,0] = indiceSeleccionado.ToString();
                Console.Write("Seleccione la cantidad de unidades del platillo deseado: ");
                platillosSeleccionados[i,1] = Console.ReadLine();
            }

            Console.WriteLine("************************");

            //Mostrar platillos seleccionados
            Console.WriteLine("Lista del pedido ");
            Console.WriteLine("COD.  PLATILLO     PRECIO UNI   TOTAL");
            for (int i = 0; i < 3; i++)
            {   int indiceMostrar = int.Parse(platillosSeleccionados[i,0]);
                int precioPlatillo = int.Parse(arregloPrecios[indiceMostrar]) * int.Parse(platillosSeleccionados[i,1]);
                int indice = indiceMostrar + 1;
                Console.WriteLine(indice + "    " + arregloPlatillos[indiceMostrar] + "  " + arregloPrecios[indiceMostrar] + "   " + precioPlatillo);
            }

            Console.WriteLine("************************");
            Console.ReadKey();
        }

        public static void menu() {
            Console.Clear();
            Console.WriteLine("Bienvenido al Restaurante de Jorge 2");
            Console.WriteLine("Presione 1: Para Carge el Menú");
            Console.WriteLine("Presione 2: Para Compra de Platillos");
            Console.WriteLine("Presione 3: Salir");
            Console.WriteLine("************************************");
        }

    }
}
