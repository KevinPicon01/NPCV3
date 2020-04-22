using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FinalQuiz : MonoBehaviour
{
    [SerializeField] GameObject scene1;
    public float x = 19.5f;
    

    public float ubicacionFinal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (x <= ubicacionFinal)
        {
            LeanTween.moveX(scene1, x, 1f);
            
        }

    }
} 
