using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIControlador : MonoBehaviour , IObservador
{
    [SerializeField] private TMP_Text nivelTexto;

    public void Ejecutar(ISujeto sujeto)
    {
        if (sujeto is Controlador)
        {
            nivelTexto.text = "Nivel: " + ((Controlador)sujeto).nivel;
        }
    }

    void Start()
    {
        Controlador.ConseguirInstancia().uiControlador = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
