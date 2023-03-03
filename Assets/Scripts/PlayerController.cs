using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Arriba = Input.GetKey("w");//Z Es la que permite moverse hacia adelante
        Abajo = Input.GetKey("s");//-Z Es la que permite moverse hacia atras
        Derecha = Input.GetKey("d");//X Es la que permite moverse a la derecha
        Izquierda = Input.GetKey("a");//-X Es la que permite moverse a la izquierda 
    }

    // Update is called once per frame
    void Update()
    {
        if(Arriba == 1)
        {
            transform.Translate(0, 0, 10);//X, Y, Z
        }
        if (Abajo == 1)
        {
            transform.Translate(0, 0, -10);
        }
        if (Derecha == 1)
        {
            transform.Translate(10, 0, 0);
        }
        if (Izquierda == 1)
        {
            transform.Translate(-10, 0, 10);
        }
    }
}
