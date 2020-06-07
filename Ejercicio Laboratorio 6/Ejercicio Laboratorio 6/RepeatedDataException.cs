using System;

namespace Ejercicio_Laboratorio_6
{
    public class RepeatedDataException : Exception
    {
        public RepeatedDataException(string message) : base(message)
        {
        }
    }
}