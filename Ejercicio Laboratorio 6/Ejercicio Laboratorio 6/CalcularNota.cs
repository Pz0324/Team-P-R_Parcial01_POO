using System;
using System.Collections.Generic;

namespace Ejercicio_Laboratorio_6
{
    public static class CalcularNota
    {
        public static double Calcular(List<Evaluacion> ev)
                {
                    double notaF = 0d;

                    foreach (var evaluacion in ev)
                    {
                        double nota = 0d;
                        Console.WriteLine("Nombre de la evaluación: " + evaluacion.Nombre);
                        Console.WriteLine("Digite una nota: ");
                        nota = Convert.ToDouble(Console.ReadLine());
                        notaF = nota * (evaluacion.Porcentaje / 100d);

                        notaF += nota;

                    }

                    Console.WriteLine("La nota final es: ");
                    return notaF;
                }
    }
}