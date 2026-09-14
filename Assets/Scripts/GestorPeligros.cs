using UnityEngine;

public class GestorPeligros : MonoBehaviour
{
    private ArbolBinarioBusqueda<PeligroData> arbolPeligros = new ArbolBinarioBusqueda<PeligroData>();

    void Start()
    {
        GameObject[] peligros = GameObject.FindGameObjectsWithTag("Peligro");
        foreach (GameObject p in peligros)
        {
            arbolPeligros.Insertar(new PeligroData(p));
        }

        foreach (var p in arbolPeligros.RecorridoInOrder())
        {
            Debug.Log(p.Objeto.name + " en X=" + p.PosicionX);
        }
    }
}