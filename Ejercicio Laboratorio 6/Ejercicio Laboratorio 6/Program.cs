using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_Laboratorio_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var ev = new List<Evaluacion>();

            byte opc = 0, opc1 = 0;
            string nombre = " ", tipo, nombreElim;
            int porcentaje = 0, preguntas, porcentajeD = 100;
            DateTime fecha;
            string menu = "1. Agregar Evaluacion\n 2. Mostar evaluaciones almacenadas\n 3. Eliminar Evaluacion\n " +
                          "4. Terminar Programa";

            string menu2 = "1. Laboratorio\n 2. Tarea\n 3. Parcial\n 0. Salir";
            do
            {
                try
                {
                    Console.WriteLine(menu);
                    opc = Convert.ToByte(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Solo se permiten numeros");
                    opc = 111;

                }

                switch (opc)
                {
                    case 1:
                        do
                        {
                            try
                            {
                                Console.WriteLine(menu2);
                                opc1 = Convert.ToByte(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Solo se permiten numeros");
                                opc1 = 111;
                            }

                            switch (opc1)
                            {
                                case 1:

                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("Digite el nombre: ");
                                            nombre = Console.ReadLine();
                                            
                                        }catch (RepeatedDataException e)
                                        { 
                                            foreach (var s in ev) {
                                            if (nombre.Equals(s.Nombre))
                                            {                              
                                                Console.WriteLine("Existen dos evaluaciones con el mismo nombre");
                                                opc = 121;
                                            }
                                        }
                                        }
                                        
                                    } while (opc == 121);

                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("Porcentaje Disponible: " + porcentajeD + "%");
                                            Console.WriteLine("Digite el porcentaje del laboratorio");
                                            porcentaje = Convert.ToInt32(Console.ReadLine());
                                            if (porcentaje <= 0 || porcentaje > porcentajeD)
                                            {
                                                Console.WriteLine("Porcentaje invalido");
                                                do
                                                {
                                                    Console.WriteLine("Porcentaje Disponible: " + porcentajeD + "%");
                                                    Console.Write("Porcentaje: ");
                                                    porcentaje = Convert.ToInt32(Console.ReadLine());

                                                    if (porcentaje <= 0 || porcentaje > porcentajeD)
                                                    {
                                                        Console.WriteLine("Porcentaje invalido");
                                                    }

                                                } while (porcentaje <= 0 || porcentaje > porcentajeD);
                                            }

                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Solo se permiten numeros");
                                            porcentaje = 111;
                                        }


                                    } while (porcentaje == 111);

                                    porcentajeD -= porcentaje;

                                    Console.WriteLine("Digite el tipo de laboratorio: ");
                                    tipo = Console.ReadLine();

                                    ev.Add(new Laboratorio(porcentaje, nombre, tipo));
                                    break;
                                case 2:
                                    Console.WriteLine("Digite el nombre: ");
                                    nombre = Console.ReadLine();

                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("Porcentaje Disponible: " + porcentajeD + "%");
                                            Console.WriteLine("Digite el porcentaje del laboratorio");
                                            porcentaje = Convert.ToInt32(Console.ReadLine());
                                            if (porcentaje <= 0 || porcentaje > porcentajeD)
                                            {
                                                Console.WriteLine("Porcentaje invalido");
                                                do
                                                {
                                                    Console.WriteLine("Porcentaje Disponible: " + porcentajeD + "%");
                                                    Console.Write("Porcentaje: ");
                                                    porcentaje = Convert.ToInt32(Console.ReadLine());

                                                    if (porcentaje <= 0 || porcentaje > porcentajeD)
                                                    {
                                                        Console.WriteLine("Porcentaje invalido");
                                                    }

                                                } while (porcentaje <= 0 || porcentaje > porcentajeD);
                                            }

                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Solo se permiten numeros");
                                            porcentaje = 111;
                                        }
                                    } while (porcentaje == 111);

                                    porcentajeD -= porcentaje;


                                    Console.WriteLine("Digite la fecha de entrega (dd.mm.aa): ");
                                    fecha = Convert.ToDateTime(Console.ReadLine());

                                    ev.Add(new Tarea(porcentaje, nombre, fecha));
                                    break;
                                case 3:
                                    Console.WriteLine("Digite el nombre: ");
                                    nombre = Console.ReadLine();

                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("Porcentaje Disponible: " + porcentajeD + "%");
                                            Console.WriteLine("Digite el porcentaje del laboratorio");
                                            porcentaje = Convert.ToInt32(Console.ReadLine());
                                            if (porcentaje <= 0 || porcentaje > porcentajeD)
                                            {
                                                Console.WriteLine("Porcentaje invalido");
                                                do
                                                {
                                                    Console.WriteLine("Porcentaje Disponible: " + porcentajeD + "%");
                                                    Console.Write("Porcentaje: ");
                                                    porcentaje = Convert.ToInt32(Console.ReadLine());

                                                    if (porcentaje <= 0 || porcentaje > porcentajeD)
                                                    {
                                                        Console.WriteLine("Porcentaje invalido");
                                                    }

                                                } while (porcentaje <= 0 || porcentaje > porcentajeD);
                                            }

                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Solo se permiten numeros");
                                            porcentaje = 111;
                                        }
                                    } while (porcentaje == 111);

                                    porcentajeD -= porcentaje;

                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("Digite la cantidad de preguntas: ");
                                            preguntas = Convert.ToInt32(Console.ReadLine());

                                            if (preguntas <= 0)
                                            {
                                                Console.Write("Las preguntas no pueden ser 0 o menos");
                                                do
                                                {
                                                    Console.WriteLine("Digite la cantidad de preguntas: ");
                                                    preguntas = Convert.ToInt32(Console.ReadLine());
                                                    if (preguntas <= 0)
                                                    {
                                                        Console.Write("Las preguntas no pueden ser 0 o menos");
                                                    }

                                                } while (preguntas < 0);
                                            }

                                            ev.Add(new Parcial(porcentaje, nombre, preguntas));
                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine("Solo se permiten numeros");
                                            porcentaje = 176;
                                        }

                                    } while (porcentaje == 176);


                                    break;
                                case 0:
                                    Console.WriteLine("Saliendo...");
                                    break;
                                default:
                                    Console.WriteLine("No es una opcion valida!");
                                    break;

                            }
                        } while (opc1 != 0);

                        break;
                    case 2:
                        if (ev.Count == 0)
                        {
                            Console.WriteLine("No hay evaluaciones almacenadas");
                        }
                        else
                        {
                            foreach (var e in ev)
                            {
                                Console.Write(e.ToString() + "\n");
                            }
                        }

                        break;
                    case 3:
                        if (ev.Count == 0)
                        {
                            Console.WriteLine("No hay evaluaciones almacenadas");
                        }
                        else
                        {
                            Console.WriteLine("Digite el nombre de la evaluación que desea eliminar: ");
                            nombreElim = Console.ReadLine();

                            ev.Remove(ev.FirstOrDefault(s =>
                            {
                                if (s.Nombre.Equals(nombreElim, StringComparison.InvariantCultureIgnoreCase))
                                {
                                    porcentajeD += s.Porcentaje;
                                    Console.WriteLine("Se eliminó exitosamente");
                                    return true;
                                }

                                return false;
                            }));

                        }

                        break;
                    case 4:
                        if (ev.Count == 0)
                        {
                            Console.WriteLine("No hay evaluaciones almacenadas");
                        }
                        else
                        {
                            do
                            {
                                try
                                {

                                    Console.WriteLine(CalcularNota.Calcular(ev));
                                    opc = 123;

                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Solo se permiten numeros");
                                    opc = 135;
                                }
                            } while (opc == 135);
                        }

                        break;
                    default:
                        Console.WriteLine("No es una opcion valida!");
                        break;
                }
            }while (opc != 123);
        }
    }
    
} 

