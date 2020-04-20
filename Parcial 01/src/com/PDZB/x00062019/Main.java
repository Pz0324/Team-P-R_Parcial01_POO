package com.PDZB.x00062019;

import javax.swing.*;
import java.lang.NumberFormatException;
import java.util.ConcurrentModificationException;

public class Main {
    static String nombre, puesto, stringaux;
    static double salario, auxdouble;
    static int mesesContrato, extension, opcaux;
    static byte opc;
    private static int opc1, opc2;

    public static void main(String[] args)  {

        Empresa Empresas = new Empresa("Empresa P&R");
        JOptionPane.showMessageDialog(null, Empresas.getNombre());
        String Menu = "1. Agregar Empleado\n 2. Despedir Empleado\n3. Ver lista de empleados\n 4. Calcular "
                + "sueldo\n 5. Mostrar totales\n 0. Salir";
        String MenuEmp = "1. Servicio Profesional\n 2. Plaza Fija\n 0. Salir";
        do {
            pedir(Menu);
            switch (opc1) {
                case 1:
                    do {
                        pedir2(MenuEmp);
                        switch (opc2) {
                            case 1:
                                do {
                                    Pedirnombre();

                                    if (nombre == null || nombre.isEmpty()) {
                                        JOptionPane.showMessageDialog(null, "Ingrese un opcion " +
                                                "valida");
                                    }
                                } while (nombre == null || nombre.isEmpty());

                                do {
                                    Perdirpuesto();

                                    if (puesto == null || puesto.isEmpty()) {
                                        JOptionPane.showMessageDialog(null, "Ingrese un opcion" +
                                                " valida");
                                    }
                                } while (puesto == null);

                                Pedirsalario();
                                Perdirmeses();

                                Empresas.addEmpleado(new ServicioProfesional(nombre, puesto, salario, mesesContrato));
                                break;
                            case 2:
                                do {
                                    Pedirnombre();

                                    if (nombre == null || nombre.isEmpty()) {
                                        JOptionPane.showMessageDialog(null, "Ingrese un opcion" +
                                                " valida");
                                    }
                                } while (nombre == null || nombre.isEmpty());

                                do {
                                    Perdirpuesto();

                                    if (puesto == null || puesto.isEmpty()) {
                                        JOptionPane.showMessageDialog(null, "Ingrese un opcion " +
                                                "valida");
                                    }
                                } while (puesto == null);

                                Pedirsalario();
                                Perdirextension();

                                Empresas.addEmpleado(new PlazaFija(nombre, puesto, salario, extension));
                                break;
                            case 0:
                                JOptionPane.showMessageDialog(null, "Saliendo...");
                                break;
                            default:
                                JOptionPane.showMessageDialog(null, "No es una opcion valida");
                                break;
                        }

                    } while (opc2 != 0);
                    break;

                case 2:
                    if (Empresas.getPlanilla().isEmpty()){
                        JOptionPane.showMessageDialog(null, "No hay empleados para despedir");
                    } else {
                        try {

                        String nombreElim = JOptionPane.showInputDialog(null, "Digite el " +
                                "nombre del empleado a eliminar: ");
                        Empresas.getPlanilla().forEach(obj ->{
                            Empresas.quitEmpleado(nombreElim);
                        });

                        JOptionPane.showMessageDialog(null, "No se encontro el empleado");
                        }catch (ConcurrentModificationException e) {
                            JOptionPane.showMessageDialog(null, "Volviendo al menu...");
                        }
                }
                    break;

                case 3:
                    if (Empresas.getPlanilla().isEmpty()) {
                        JOptionPane.showMessageDialog(null, "No hay empleados para ver");
                    } else {
                        Empresas.getPlanilla().forEach(oj -> {
                            JOptionPane.showMessageDialog(null, oj.toString());
                        });
                    }
                    break;
                case 4:
                    if (Empresas.getPlanilla().isEmpty()) {
                        JOptionPane.showMessageDialog(null, "No hay empleados para calcular su" +
                                " sueldo");
                    } else {
                        try  {
                        String EmpSueldo = JOptionPane.showInputDialog(null, "Digite el nombre " +
                                "del empleado para buscar su sueldo: ");
                        Empresas.getPlanilla().forEach(obj -> {
                            if (EmpSueldo.equalsIgnoreCase(obj.getNombre())) {
                                JOptionPane.showMessageDialog(null, "Su Salario es: $ " +
                                        salario);
                                CalculadoraImpuestos.CalcularPago(obj);
                            }

                        });
                            JOptionPane.showMessageDialog(null, "No se encontro el empleado");
                        }catch (ConcurrentModificationException e) {
                            JOptionPane.showMessageDialog(null, "Volviendo al menu...");
                        }
                    }
                    break;
                case 5:
                    if (Empresas.getPlanilla().isEmpty()) {
                        JOptionPane.showMessageDialog(null, "NO hay empleados para mostrar " +
                                "sus totales");
                    } else {
                        JOptionPane.showMessageDialog(null, CalculadoraImpuestos.mostrarTotales());
                    }
                    break;
                case 0:
                    JOptionPane.showMessageDialog(null, "Saliendo...");
                    break;
                default:
                    JOptionPane.showMessageDialog(null, "NO es una opcion valida");
            }

        } while (opc1 != 0);

    }

    static Empleado EmpServicioProfesional() throws NumberFormatException {

        String nombre;
        nombre = JOptionPane.showInputDialog(null, "Nombre: ");
        if (nombre == null) {
            JOptionPane.showMessageDialog(null, "Ingreso una opcion invalida");

            do {
                nombre = JOptionPane.showInputDialog(null, "Nombre: ");

                if (nombre == null) {
                    JOptionPane.showMessageDialog(null, "Ingreso una opcion invalida");
                }

            } while (nombre == null);
        }
        String puesto;
        puesto = JOptionPane.showInputDialog(null, "Puesto: ");
        if (puesto == null) {
            JOptionPane.showMessageDialog(null, "Ingreso una opcion invalida");

            do {
                puesto = JOptionPane.showInputDialog(null, "Puesto: ");

                if (nombre == null) {
                    JOptionPane.showMessageDialog(null, "Ingreso una opcion invalida");
                }
            } while (nombre == null);
        }

        double salario = 0;
        int mesesContrato = 0;
        try {
            salario = Double.parseDouble(JOptionPane.showInputDialog(null, "Salario: "));
            mesesContrato = Integer.parseInt(JOptionPane.showInputDialog(null, "Meses de " +
                    "contrato: "));

        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Solo se permite ingresar numeros");
            EmpServicioProfesional();
        }

        return new ServicioProfesional(nombre, puesto, salario, mesesContrato);
    }

    static Empleado EmpPlazaFija() throws NumberFormatException {

        String nombre;
        nombre = JOptionPane.showInputDialog(null, "Nombre: ");
        if (nombre == null) {
            JOptionPane.showMessageDialog(null, "Ingreso una opcion invalida");

            do {
                nombre = JOptionPane.showInputDialog(null, "Nombre: ");

                if (nombre == null) {
                    JOptionPane.showMessageDialog(null, "Ingreso una opcion invalida");
                }

            } while (nombre == null);
        }
        String puesto;
        puesto = JOptionPane.showInputDialog(null, "Puesto: ");
        if (puesto == null) {
            JOptionPane.showMessageDialog(null, "Ingreso una opcion invalida");

            do {
                puesto = JOptionPane.showInputDialog(null, "Puesto: ");

                if (nombre == null) {
                    JOptionPane.showMessageDialog(null, "Ingreso una opcion invalida");
                }

            } while (nombre == null);

        }

        double salario = 0;
        int mesesContrato = 0;

        try {
            salario = Double.parseDouble(JOptionPane.showInputDialog(null, "Salario: " ));
            mesesContrato = Integer.parseInt(JOptionPane.showInputDialog(null, "Meses de" +
                    " contrato: "));

        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Ingreso un valor no valido");
            EmpServicioProfesional();
        }

        return new PlazaFija(nombre, puesto, salario, mesesContrato);
    }

    static Documento AnadirDoc()  {
        String nombreD = JOptionPane.showInputDialog(null, "Nombre:");
        String numero = JOptionPane.showInputDialog(null, "Numero: ");


        return new Documento(nombreD, numero);
    }

    static void pedir(String Menu)
    {
        try {
            opcaux = Integer.parseInt(JOptionPane.showInputDialog(null, Menu));

            opc1 = opcaux;

        } catch (NumberFormatException String) {

            JOptionPane.showMessageDialog(null, "Ingreso un valor no valido");
            pedir(Menu);
        }
    }
    static void pedir2 (String MenuEmp){

        try {
            opcaux = Integer.parseInt(JOptionPane.showInputDialog(null, MenuEmp));

            opc2 = opcaux;

        } catch (NumberFormatException String) {

            JOptionPane.showMessageDialog(null, "Ingreso  un valor no valido");
            pedir(MenuEmp);
        }
    }

    static void Pedirnombre () {

        try {
            stringaux = JOptionPane.showInputDialog(null, "Nombre: ");
            nombre = stringaux;

        } catch (NumberFormatException String) {

            JOptionPane.showMessageDialog(null, "Ingreso un valor no valido");
            Pedirnombre();
        }

    }

    static void Perdirpuesto (){

        try {
            stringaux = JOptionPane.showInputDialog(null, "Puesto: ");
            puesto = stringaux;

        } catch (NumberFormatException String) {

            JOptionPane.showMessageDialog(null, "Ingreso un valor no valido");
            Perdirpuesto();
        }

    }

    static void Pedirsalario() {

        try {
            auxdouble = Double.parseDouble(JOptionPane.showInputDialog(null, "Salario: "));
            salario = auxdouble;

        } catch (NumberFormatException String) {

            JOptionPane.showMessageDialog(null, "Ingreso un valor no valido");
            Pedirsalario();
        }

    }

    static void Perdirmeses (){

        try {
            opcaux = Integer.parseInt(JOptionPane.showInputDialog(null, "Meses contrato: "));

            mesesContrato = opcaux;

        } catch (NumberFormatException String) {

            JOptionPane.showMessageDialog(null, "Ingreso un valor no valido");
            Perdirmeses();
        }

    }

    static void Perdirextension(){

        try {
            opcaux = Integer.parseInt(JOptionPane.showInputDialog(null, "Extension: "));

            extension = opcaux;

        } catch (NumberFormatException String) {

            JOptionPane.showMessageDialog(null, "Ingreso un valor no valido");
            Perdirextension();
        }
    }

    static String MenuDoc(){

        return "¿Desea agregar un documento?\n 1. Agregar documento\n 2. Eliminar Documento\n 0. Salir";
    }

}