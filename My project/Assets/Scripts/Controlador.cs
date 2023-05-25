using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using Unity.VisualScripting;

public class Controlador : Niveles , ISujeto
{
    public static Controlador instancia { get; private set; }

    [SerializeField]
    private TextMeshProUGUI nivelActual;
    public int nivel = 0;
    public UIControlador uiControlador;

    private void Awake()
    {
        instancia = this;
    }

    public static Controlador ConseguirInstancia()
    {
        return instancia;
    }

    private void Start()
    {
        ActualizarNivel();
    }

    public override void IncrementarNivel(int valor)
    {
        nivel += valor;
        ActualizarNivel();
    }

    private void ActualizarNivel()
    {
        nivelActual.text = $"{nivel}";
    }

    public void Attach(IObservador observerdor)
    {
        throw new System.NotImplementedException();
    }

    public void Detach(IObservador observador)
    {
        throw new System.NotImplementedException();
    }

    public void Notificar()
    {
        throw new System.NotImplementedException();
    }
}
