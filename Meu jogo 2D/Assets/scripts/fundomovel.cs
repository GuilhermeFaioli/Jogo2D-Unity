using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fundomovel : MonoBehaviour {

    private Material currentMaterial;
    public float speed;
    private float offset;

	// Use this for initialization
	void Start () {
        currentMaterial = GetComponent<Renderer>().material;

    }
	
	// Update is called once per frame
	void Update () {
        offset += 0.001f;

        currentMaterial.SetTextureOffset("_MainTex", new Vector2(offset*speed, 0));

    }
}
