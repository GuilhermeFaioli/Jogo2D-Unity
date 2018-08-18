using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

    public Transform mesh;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<Rigidbody2D>().velocity.y < 0)
        {
            mesh.eulerAngles -= new Vector3(0, 0, 2f);
            if (mesh.eulerAngles.z < 330 && mesh.eulerAngles.z > 30)
            {
                mesh.eulerAngles = new Vector3(0, 0, 180);
            }
        }
        else if (GetComponent<Rigidbody2D>().velocity.y > 0)
        {
            mesh.eulerAngles += new Vector3(0, 0, 2f);
            if (mesh.eulerAngles.z > 90)
            {
                mesh.eulerAngles = new Vector3(0, 0, 110);
            }
            if (mesh.eulerAngles.z < 90)
            {
                mesh.eulerAngles = new Vector3(0, 0, 70);
            }
        }
    }
}
