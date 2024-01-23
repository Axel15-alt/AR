using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputtouchmanager : MonoBehaviour
{
    Vector2 ultimaPosicion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            var posicionActual = Input.GetTouch(0).position;

            float x = posicionActual.x - ultimaPosicion.x;

            transform.Rotate(transform.up *x* Time.deltaTime * 100);
        }

    }
}
