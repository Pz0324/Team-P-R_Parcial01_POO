using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Laboratorio_10
{
    public class CuentaBancaria
    {
        private double saldo;
        private string nombre;
        static List<CuentaBancaria> CuentasBancarias = new List<CuentaBancaria>();
        
        public CuentaBancaria(string nombre, double saldo)
        {

            this.nombre = nombre;
            this.saldo = saldo;
        }

      
        public static List<CuentaBancaria> CuentasBancarias1
        {
            get => CuentasBancarias;
            
        }

        public static string Datos()
        {
            string info = "Nombre Saldo";

            foreach (var cn in CuentasBancarias)
            {
                info += $"\n{cn.nombre}{cn.saldo}";
            }

            return info;
        }
    }
}