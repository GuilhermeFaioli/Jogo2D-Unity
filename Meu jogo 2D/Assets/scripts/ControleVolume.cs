using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleVolume : MonoBehaviour {

    private float volumeMaster;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void VolumeMaster(float volume)
    {
        volumeMaster = volume;
        AudioListener.volume = volumeMaster;
    }
}
