using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
        if (name == "level1")
        {
            Time.timeScale = 1;
        }
        if (name == "level2")
        {
            Time.timeScale = 1;
        }
        if (name == "Menu")
        {
            Time.timeScale = 1;
        }
    }
}
