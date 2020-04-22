using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using Random = System.Random;
public class Activable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Generar();
        
    }

    void Generar()
    {
        Random rnd = new Random();
        var value = rnd.Next(10, 90);
        var value2 = rnd.Next(-2, 2);
        transform.position = new Vector3(value2,value,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
