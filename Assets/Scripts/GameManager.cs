using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool pausa ;
    public GameObject camera;
    public GameObject menuPausa;
    // Start is called before the first frame update
    void Start()
    { 
        pausa = true;
        Time.timeScale = 1.0f;
    }
    void Pausar()
    {
          
        if (pausa)
        {
            Time.timeScale = 0.0f;
            pausa = false;
            menuPausa.transform.SetPositionAndRotation(new Vector3(camera.transform.position.x,camera.transform.position.y,1), Quaternion.identity); 
            
        }

        else
        {
            Time.timeScale = 1.0f;
            pausa = true;
            menuPausa.gameObject.transform.Translate(new Vector3(10f,10f,0f));
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
            Pausar();

        if (Input.GetKeyDown(KeyCode.R))
        {
            
            SceneManager.LoadScene("SampleScene");
            
        }
    }

    

    private void FixedUpdate()
    {
        
    }
}
