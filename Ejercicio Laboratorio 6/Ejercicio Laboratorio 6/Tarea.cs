﻿using System;

namespace Ejercicio_Laboratorio_6
{
    public class Tarea : Evaluacion
    {
        private DateTime fechaEntrega { get; }
        
                public Tarea(int porcentaje, string nombre, DateTime fechaEntrega) : base(porcentaje, nombre)
                {
                    this.fechaEntrega = fechaEntrega;
                }

                public override string ToString()
                {
                    return $"{base.ToString()}, {nameof(fechaEntrega)}: {fechaEntrega}";
                }
    }
}