using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISujeto
{
    void Attach(IObservador observerdor);
    void Detach(IObservador observador);
    void Notificar();
}
