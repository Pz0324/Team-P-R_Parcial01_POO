package com.PDZB.x00062019;

import javax.swing.*;
import java.util.ArrayList;

public  class Empresa  {
    private ArrayList<Empleado> Planilla = new ArrayList<>();
    private String nombre;

    public Empresa(String nombre) {
        this.nombre = nombre;
    }

    public ArrayList<Empleado> getPlanilla() {
        return Planilla;
    }

    public String getNombre() {
        return nombre;
    }

    public void addEmpleado(Empleado anadirEmp) throws NumberFormatException{
        Planilla.add(anadirEmp);
        byte opc = 0;

        try {
        do {
            opc = Byte.parseByte(JOptionPane.showInputDialog(null, Main.MenuDoc()));
            switch (opc) {
                case 1:
                    anadirEmp.addDocumento(Main.AnadirDoc());
                    break;
                case 2:
                    if(anadirEmp.Documentos.isEmpty()){

                        JOptionPane.showMessageDialog(null,"La lista esta vacia");

                    }else {

                        String ElimDoc = JOptionPane.showInputDialog(null, "Escriba el nombre" +
                                " del documento que desa eliminar");
                        if (ElimDoc == null) {
                            JOptionPane.showMessageDialog(null, "Ingresa una opcion invalida");
                            do {
                                ElimDoc = JOptionPane.showInputDialog(null, "Escriba el nombre" +
                                        " del documento que desea eliminar");

                                if (ElimDoc == null) {
                                    JOptionPane.showMessageDialog(null, "Ingrese un opcion" +
                                            " valida");
                                }
                            } while (ElimDoc == null);

                        }
                        anadirEmp.removeDocumentos(ElimDoc);
                    }

                case 0:
                    JOptionPane.showMessageDialog(null, "Saliendo...");
                    break;

                default:
                    JOptionPane.showMessageDialog(null, "No es una opción válida");
            }
        }while (opc != 0);
        }catch (NumberFormatException e){
            JOptionPane.showMessageDialog(null, "Solo se permiten numeros");
            JOptionPane.showInputDialog(null,Main.MenuDoc());
        }
    }
    public void quitEmpleado(String eliminarEmp) {
        String finalEliminarEmp = eliminarEmp;
        Planilla.removeIf(obj ->{
            if(obj.getNombre().equalsIgnoreCase(finalEliminarEmp)){
                JOptionPane.showMessageDialog(null, "Se ha despedido al empleado");
                return true;
            }
            return false;
        });

    }


}