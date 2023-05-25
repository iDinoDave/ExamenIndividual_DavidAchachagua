using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Boton1 : MonoBehaviour
{
    private int masUno  = 1;

    public void IncrementarNivel(int valor)
    {
        Controlador.ConseguirInstancia().IncrementarNivel(masUno);
    }
}
