﻿using System;
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
                Console.WriteLine("6- Alta Reserva");
                Console.WriteLine("7- Reservas de un Socio");
                Console.WriteLine("8- Reservas de una Cancha");
                Console.WriteLine("0- Salir");
                
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
                        Console.WriteLine("Ingrese Codigo de cancha");
                        int codigoCancha = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Descripcion");
                        string description = Console.ReadLine();
                        Console.WriteLine("Ingrese Ubicacion");
                        string ubicacion = Console.ReadLine();
                        /*Instanciar*/
                        if (c.altaCancha(codigoCancha, description, ubicacion))
                        {
                            Console.WriteLine("La Cancha " + codigoCancha + " fue ingresada correctamente");
                        }
                        else {
                            Console.WriteLine("La Cancha " + codigoCancha + " ya existe");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("4- Listado de Socios");
                        Console.WriteLine(c.listarSocios());
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("5- Listado de Canchas");
                        Console.WriteLine(c.listarCanchas());
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("6- Alta Reserva");
                        Console.WriteLine(c.listarSocios());
                        Console.WriteLine("Ingrese numero de socio que va a realizar la reserva:");
                        int numeroSocio = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(c.listarCanchas());
                        Console.WriteLine("Ingrese el codigo de cancha que va a reservar");
                        int numeroCancha = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese fecha de la Reserva");
                        DateTime fechaReserva = Convert.ToDateTime(Console.ReadLine());
                        c.altaReserva(numeroSocio, numeroCancha, fechaReserva);
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("7- Reservas de un Socio");
                        Console.WriteLine(c.listarSocios());
                        Console.WriteLine("Ingrese numero de socio que va a consultar:");
                        int codSocio = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(c.reservasPorSocio(codSocio));
                        
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("8- Reservas de una Cancha");
                        Console.WriteLine(c.listarCanchas());
                        Console.WriteLine("Ingrese numero de cancha que va a consultar:");
                        int codCancha = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(c.reservasPorCancha(codCancha));

                        break;
                }
            } while (currentOption != 0);
        }
    }
}
