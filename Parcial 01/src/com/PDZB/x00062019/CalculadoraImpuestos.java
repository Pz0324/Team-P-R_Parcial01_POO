package com.PDZB.x00062019;

public final class CalculadoraImpuestos  {
    private static double TotalRenta, TotalISSS, TotalAFP;

    private CalculadoraImpuestos(){
    }
    public static double CalcularPago(Empleado pago)  {
        double pagoEmp = 0, x, renta = 0, AFP, ISSS;

        if (pago instanceof ServicioProfesional) {
            renta = 0.1 * pago.getSalario();
            pagoEmp = pago.getSalario() - renta;
            TotalRenta = TotalRenta + renta;

            return pagoEmp;
        }
        if (pago instanceof PlazaFija) {
            AFP= 0.0625 * pago.getSalario();
            ISSS = 0.03 * pago.getSalario();
            x = pago.getSalario() - AFP - ISSS;
            TotalISSS = TotalISSS + ISSS;
            TotalAFP = TotalAFP + AFP;

            if(x >=  0.01 &&  x <= 472.0)
                renta = 0;
            pagoEmp = x - renta;
            TotalRenta = TotalRenta + renta;
            if(x >= 472.01 && x <= 895.24)
                renta = 0.1 * (x - 472) + 17.67;
            pagoEmp = x - renta;
            TotalRenta = TotalRenta + renta;
            if(x >= 895.25 && x <= 2038.10)
                renta = 0.2 * (x - 895.24) + 60;
            pagoEmp = x - renta;
            TotalRenta = TotalRenta + renta;
            if(x >= 2038.11)
                renta = 0.3 * (x - 2038.10) + 288.57;
            pagoEmp = x - renta;
            TotalRenta = TotalRenta + renta;
        }
        return pagoEmp;
    }

    public static String mostrarTotales(){
        String totales = "Los totales son:\n Total AFP: " + TotalAFP + "Total ISSS:" + TotalISSS + "Total Renta: "
                + TotalRenta;

        return totales;
    }


}
