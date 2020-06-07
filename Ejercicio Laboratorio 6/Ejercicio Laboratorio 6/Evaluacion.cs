namespace Ejercicio_Laboratorio_6
{
    public class Evaluacion
    {

        protected int porcentaje;
        protected string nombre;

        public int Porcentaje => porcentaje;

        public string Nombre => nombre;

        public Evaluacion(int porcentaje, string nombre)
                {
                    this.porcentaje = porcentaje;
                    this.nombre = nombre;
                }

        public override string ToString()
        {
            return $"{nameof(porcentaje)}: {porcentaje}, {nameof(nombre)}: {nombre}";
        }
    }
            
    }
