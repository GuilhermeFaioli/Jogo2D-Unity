using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pontuacao : MonoBehaviour {

    private int recorde;
    private static int pontos = 0;
    public GameObject textPontos;
    public float x = 0;

	// Use this for initialization
	void Start () {
        pontos = 0;
        GetComponent<Text>().text = "0";
        Recorde();
	}
	
	// Update is called once per frame
	void Update () {
        if (x==1)
        {
            if (pontos ==35)
            {
                SceneManager.LoadScene("level2");
            }
        }
        
        
    }

    public void Hit()
    {
        if(Time.timeScale != 1.000001f)
        {
            ++pontos;
            GetComponent<Text>().text = pontos.ToString();
        }
        
    }

    public void Recorde()
    {
        if (pontos>PlayerPrefs.GetInt("Recorde"))
        {
            PlayerPrefs.SetInt("Recorde", pontos);
        }
        if (textPontos != null)
        {
            textPontos.GetComponent<Text>().text = "Recorde: "+PlayerPrefs.GetInt("Recorde").ToString();
        }
        
    }

  
}
