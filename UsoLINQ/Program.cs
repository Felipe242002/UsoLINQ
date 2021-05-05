using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            procesador();

            Console.WriteLine("¿Quiere agregar otro producto?");
            Console.WriteLine("Opcion 1: Si");
            Console.WriteLine("Opcion 2: No");
            int opcion = int.Parse (Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Usted selecciono la opcion: Si");
                procesador();

            }else if (opcion == 2)
            {
                Console.WriteLine("Usted selecciono la opcion: No");
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Usted no selecciono ninguna opcion.");
                procesador();
            }
            
            void procesador()
            {
                BaseDato bd = new BaseDato();

                var procesadoresOrdenados = bd.Procesadores.OrderByDescending(p => p.precio).ToList();
                var procesadorCaro = procesadoresOrdenados.First();


                Procesadores Procesador1 = new Procesadores();

                //Procesador1.id = 100;
                Console.WriteLine("Ingrese la marca del procesador: ");
                Procesador1.marca = Console.ReadLine();
                Console.WriteLine("Ingrese el tipo de plataforma: ");
                Procesador1.plataforma = Console.ReadLine();
                Console.WriteLine("Ingrese el modelo del procesador: ");
                Procesador1.modelo = Console.ReadLine();
                Console.WriteLine("Ingrese el tipo de linea del procesador: ");
                Procesador1.linea = Console.ReadLine();
                Console.WriteLine("Ingrese el tipo de socket: ");
                Procesador1.socket = Console.ReadLine(); ;
                Console.WriteLine("Ingrese la velocidad base del procesador: ");
                Procesador1.velocidad = Console.ReadLine();
                Console.WriteLine("Ingrese el stock que hay del procesador: ");
                Procesador1.stock = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el precio del procesador: ");
                Procesador1.precio = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de nucleos que tiene el procesador: ");
                Procesador1.cantidad_nucleos = int.Parse(Console.ReadLine());

                bd.Procesadores.Add(Procesador1);
                bd.SaveChanges();

                Console.WriteLine("¿Desea ver el procesador mas caro?");
                Console.WriteLine("Opcion 1: Si");
                Console.WriteLine("Opcion 2: No");
                int opcion2 =  int.Parse (Console.ReadLine());

                if (opcion2 == 1)
                {
                    Console.WriteLine("Usted selecciono ver el procesador mas caro.");
                    Console.WriteLine(procesadorCaro);
                }else if (opcion2 == 2)
                {
                    Console.WriteLine("Usted selecciono no ver el procesador mas caro.");
                }

                Console.WriteLine("Procesador agregado correctamente.");

                Console.ReadLine();
            }
            
        }
    }
}
