using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Vidas : MonoBehaviour {

    
    public Sprite[] Vida;
    private int tamanhoVidas;
    private int index = 0;
    public GameObject perdeu;
    public GameObject escondeBotao1;
    public GameObject escondeBotao2;
    public GameObject botaopause;
    private int i=0;
    public Pontuacao pontos;

    // Use this for initialization
    void Start () {
        perdeu.SetActive(false);
        escondeBotao1.SetActive(false);
        escondeBotao2.SetActive(false);
        GetComponent<Image>().sprite = Vida[0];
        tamanhoVidas = Vida.Length;
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    
    public bool Remover()
    {
        if (tamanhoVidas < 0)
        {
            return false;
        }
        if(index<(tamanhoVidas - 1))
        {
            index++;
            GetComponent<Image>().sprite = Vida[index];
            i++;
            if (i > 2)
            {
                perdeu.SetActive(true);
                escondeBotao1.SetActive(true);
                escondeBotao2.SetActive(true);
                botaopause.SetActive(false);
                Time.timeScale = 1.000001f;
            }
            return true;
        }
        return false;
        

    }
}
