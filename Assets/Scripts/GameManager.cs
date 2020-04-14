using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class GameManager : MonoBehaviour
{
    public bool pausa ;
    public GameObject camera;
    public GameObject menuPausa;
    [SerializeField] private GameObject componente1;
    [SerializeField] private GameObject componente2;
    [SerializeField] private GameObject componente3;
    [SerializeField] private GameObject componente4;
    [SerializeField] private GameObject componente5;
    [SerializeField] private GameObject componente6;
    [SerializeField] private GameObject componente7;
    [SerializeField] private GameObject componente8;
    [SerializeField] private GameObject componente9;
    [SerializeField] private GameObject componente10;
    private List<GameObject> componentes = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    { 
        Random rnd = new Random();
        pausa = true;
        Time.timeScale = 1.0f;
        componentes.Add(componente1);
        componentes.Add(componente2);
        componentes.Add(componente3);
        componentes.Add(componente4);
        componentes.Add(componente5);
        componentes.Add(componente6);
        componentes.Add(componente7);
        componentes.Add(componente8);
        componentes.Add(componente9);
        componentes.Add(componente10);
       for (int i = 0; i < 10; i++)
        {
            var value = rnd.Next(0, 9);
            
            componentes[value].gameObject.transform.position = new Vector3(0,i * 10,0);
            componentes.RemoveAt(value);
        }
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
