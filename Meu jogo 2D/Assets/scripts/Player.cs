using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Vector3 position;
    private bool morte;
    private Pontuacao pontos;
    private Vidas vida;
    //private Pause pause;
    
    public AudioClip clipMosquito;
    public AudioClip clipNumero;



    

    void Start() {
        
        pontos = GameObject.FindGameObjectWithTag("Pontos").GetComponent<Pontuacao>() as Pontuacao;



    }

    // Update is called once per frame
    void Update() {
        Plataforma();
    }

   

    private void Plataforma()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.touchCount == 1)
            {
                position = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 1));
                transform.position = new Vector2(position.x, position.y);

                GetComponent<Collider2D>().enabled = true;
                return;
            }

            GetComponent<Collider2D>().enabled = false;
        }
        else
        {
            position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            transform.position = new Vector2(position.x, position.y);
        }


    }

   

    private void OnTriggerEnter2D(Collider2D collisor)
    {
        if (collisor.tag == "Mosquitos")
        {
            collisor.GetComponent<Item>().InstanciarDestruir();
            Audio(clipMosquito);
            pontos.Hit();
            
                
            
        } 
    }

    private void Audio(AudioClip clip)
    {
        //GetComponent<audio>().clip = clip;
        AudioSource.PlayClipAtPoint(clip, transform.position, 0.2f);
    }
}
