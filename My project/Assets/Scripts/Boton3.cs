using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Boton3 : MonoBehaviour
{
    private int masTres = 3;

    public void IncrementarNivel(int valor)
    {
        Controlador.ConseguirInstancia().IncrementarNivel(masTres);
    }
}
