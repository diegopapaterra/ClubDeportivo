using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Club c = new Club();
            int currentOption = 0;
            do
            {
                Console.WriteLine("----*Menu*----");
                Console.WriteLine("1- Alta Socio Particular");
                Console.WriteLine("2- Alta Socio Familiar");
                Console.WriteLine("3- Alta Cancha");
                Console.WriteLine("4- Listar Socios");
                Console.WriteLine("5- Listar Canchas");
                Console.WriteLine("6- Salir");
                
                currentOption = Convert.ToInt32(Console.ReadLine());
                switch (currentOption)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1- Alta Socio Particular");
                        Console.WriteLine("Ingrese Numero de Socio");
                        int nroSocio = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Apellido");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese Fecha de Antiguedad");
                        DateTime fechaAntiguedad = Convert.ToDateTime(Console.ReadLine());
                        /*Instanciar*/
                        if (c.altaParticular(nroSocio, nombre, apellido, fechaAntiguedad))
                        {
                            Console.WriteLine("El usuario " + nroSocio + " fue ingresado correctamente");
                        }
                        else {
                            Console.WriteLine("El usuario " + nroSocio + " ya existe");
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("2- Alta Socio Familiar");
                        Console.WriteLine("Ingrese Numero de Socio");
                        int nroSocioFamiliar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Nombre");
                        string nombreFamiliar = Console.ReadLine();
                        Console.WriteLine("Ingrese Apellido");
                        string apellidoFamiliar = Console.ReadLine();
                        Console.WriteLine("Ingrese Cantidad de Integrantes");
                        int cantIntegrantes = Convert.ToInt32(Console.ReadLine());
                        /*Instanciar*/
                        if (c.altaFamiliar(nroSocioFamiliar, nombreFamiliar, apellidoFamiliar, cantIntegrantes))
                        {
                            Console.WriteLine("El usuario " + nroSocioFamiliar + " fue ingresado correctamente");
                        }
                        else {
                            Console.WriteLine("El usuario " + nroSocioFamiliar + " ya existe");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("3- Alta Cancha");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("4- Listado de Socios");
                        Console.WriteLine(c.listarSocios());
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("4- Listado de Canchas");
                        
                        Console.ReadKey();
                        break;
                }
            } while (currentOption != 6);
        }
    }
}
