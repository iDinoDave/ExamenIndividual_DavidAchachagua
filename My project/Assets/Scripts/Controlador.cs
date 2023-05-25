using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using Unity.VisualScripting;

public class Controlador : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI nivelActual;
    private int nivel = 0;

    private void Start()
    {
        ActualizarNivel();
    }

    public void IncrementarNivel(int valor)
    {
        nivel += valor;
        ActualizarNivel();
    }

    private void ActualizarNivel()
    {
        nivelActual.text = $"Resultado: {nivel}";
    }
}
