package com.PDZB.x00062019;

import javax.swing.*;
import java.util.ArrayList;
import java.util.ConcurrentModificationException;

public abstract class Empleado {
    protected String nombre, puesto;
    protected double salario;
    protected ArrayList<Documento> Documentos = new ArrayList<>();

    public Empleado(String nombre, String puesto, double salario) {
        this.nombre = nombre;
        this.puesto = puesto;
        this.salario = salario;
    }
    public String getNombre() {
        return nombre;
    }

    public String getPuesto() {
        return puesto;
    }

    public ArrayList<Documento> getDocumentos() {
        return Documentos;
    }

    public void addDocumento(Documento anadirDoc) {
        Documentos.add(anadirDoc);

    }
    public void removeDocumentos(String elimDoc) {
        try {
            final String finalElimDoc = elimDoc;
            Documentos.removeIf(obj -> {
                if (obj.getNombre().equalsIgnoreCase(finalElimDoc)) {
                    JOptionPane.showMessageDialog(null, "Se ha eliminado el documento ");
                    return true;
                }
                return false;
            });
            JOptionPane.showMessageDialog(null, "No se encontro el documento");
        } catch (
                ConcurrentModificationException e) {
            JOptionPane.showMessageDialog(null, "Volviendo al menu...");
        }
    }
    public double getSalario() {
        return salario;
    }

    public void setSalario(double salario) {
        this.salario = salario;
    }

    @Override
    public String toString() {
        return "Empleado{" +
                "Nombre:'" + nombre + '\'' +
                ", Puesto:'" + puesto + '\'' +
                ", Salario: " + salario +
                ", Documentos: " + Documentos +
                '}';
    }
}