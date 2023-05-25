using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton2 : MonoBehaviour
{
    private int masDos = 2;

    public void IncrementarNivel(int valor)
    {
        Controlador.ConseguirInstancia().IncrementarNivel(masDos);
    }
}
