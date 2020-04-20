package com.PDZB.x00062019;

public class Documento {
    private String nombre;
    private String numero;

    public Documento(String nombre, String numero) {
        this.nombre = nombre;
        this.numero = numero;

    }

    public String getNumero() {
        return numero;
    }

    public String getNombre() {
        return nombre;
    }

    @Override
    public String toString() {
        return "Documento{" +
                "Nombre '" + nombre + '\'' +
                ", Numero:'" + numero + '\'' +
                '}';
    }
}