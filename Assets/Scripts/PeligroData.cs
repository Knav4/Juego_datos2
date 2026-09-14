using System;
using UnityEngine;
public class PeligroData : IComparable<PeligroData>{
    public string nombre;
    public int nivelPeligro;

    public PeligroData(string nombre, int nivelPeligro)
    {
        this.nombre = nombre;
        this.nivelPeligro = nivelPeligro;
    }

    public int CompareTo(PeligroData other)
    {
        if (other == null) return 1;
        return this.nivelPeligro.CompareTo(other.nivelPeligro);
    }
}