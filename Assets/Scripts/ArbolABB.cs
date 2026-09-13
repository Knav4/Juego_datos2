using System;
using System.Collections.Generic;

public class ArbolABB<T> where T : IComparable<T>
{
    public Nodo<T> Raiz { get; private set; }

    public void Insertar(T valor)
    {
        Raiz = InsertarRec(Raiz, valor);
    }

    private Nodo<T> InsertarRec(Nodo<T> nodo, T valor)
    {
        if (nodo == null)
            return new Nodo<T>(valor);

        int comparacion = valor.CompareTo(nodo.Valor);
        if (comparacion < 0)
            nodo.Izquierdo = InsertarRec(nodo.Izquierdo, valor);
        else if (comparacion > 0)
            nodo.Derecho = InsertarRec(nodo.Derecho, valor);

        return nodo;
    }
        public bool Buscar(T valor)
    {
        return BuscarRec(Raiz, valor);
    }

    private bool BuscarRec(NodoABB<T> nodo, T valor)
    {
        if (nodo == null) return false;

        int comparacion = valor.CompareTo(nodo.Valor);
        if (comparacion == 0) return true;
           if(comparacion < 0)
                return BuscarRec(nodo.Izquierdo, valor);
            else
                return BuscarRec(nodo.Derecho, valor);
        public void Eliminar(T valor)
    {
        Raiz = EliminarRec(Raiz, valor);
    }

    private NodoABB<T> EliminarRec(NodoABB<T> nodo, T valor)
    {
        if (nodo == null) return null;

        int comparacion = valor.CompareTo(nodo.Valor);
        if (comparacion < 0)
            nodo.Izquierdo = EliminarRec(nodo.Izquierdo, valor);
        else if (comparacion > 0)
            nodo.Derecho = EliminarRec(nodo.Derecho, valor);
        else
        {
            if (nodo.Izquierdo == null) return nodo.Derecho;
            if (nodo.Derecho == null) return nodo.Izquierdo;

            NodoABB<T> sucesor = ObtenerMinimo(nodo.Derecho);
            nodo.Valor = sucesor.Valor;
            nodo.Derecho = EliminarRec(nodo.Derecho, sucesor.Valor);
        }
        return nodo;
    }

    private NodoABB<T> ObtenerMinimo(NodoABB<T> nodo)
    {
        while (nodo.Izquierdo != null)
            nodo = nodo.Izquierdo;
        return nodo;
    }
    public List<T> RecorridoInOrden()
    {
        List<T> resultado = new List<T>();
        RecorridoInOrdenRec(Raiz, resultado);
        return resultado;
    }
    private void RecorridoInOrdenRec(NodoABB<T> nodo, List<T> resultado)
    {
        if (nodo != null)
        {
            RecorridoInOrdenRec(nodo.Izquierdo, resultado);
            resultado.Add(nodo.Valor);
            RecorridoInOrdenRec(nodo.Derecho, resultado);
        }
    }
}