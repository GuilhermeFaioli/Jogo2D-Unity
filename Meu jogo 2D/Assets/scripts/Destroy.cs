using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public float speed;
    private float aux=1;

    // Use this for initialization
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        aux -= speed * Time.deltaTime;
        if (aux <= 0)
        {
            Destroy(gameObject);
        }

    }

}
