using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour {

    public float minSpawnTime;
    public float maxSpawnTime;
    public float spawnItem;

    public GameObject[] Itens;
    private GameObject item;

    public float upForce = 400f;
    public float leftForce = 200f;
    public static float minX, maxX;
    private int index;


    // Use this for initialization
    void Start () {

        minX = GerenciarCamera.MinX();
        maxX = GerenciarCamera.MaxX();
        StartCoroutine("Instanciador");
    }
	
	// Update is called once per frame
	void Update () {

        

    }

    bool RandomItem()
    {
        if (Itens.Length > 0)
        {
            index = Random.Range(0, Itens.Length);
            return true;
        }
        return false;
    }

    private IEnumerator Instanciador()
    {
        spawnItem = Random.Range(minSpawnTime, maxSpawnTime);
        yield return new WaitForSeconds(spawnItem);
        if(RandomItem())
        {
            item = Instantiate(Itens[index], new Vector2(Random.Range(minX, maxX), transform.position.y), Quaternion.Euler(0,0, Random.Range(-60,60))) as GameObject;

            if (item.transform.position.x > 0)
            {
                item.GetComponent<Rigidbody2D>().AddForce(new Vector2(-leftForce, upForce));
            }
            else
            {
                item.GetComponent<Rigidbody2D>().AddForce(new Vector2(leftForce, upForce));
            }

            StartCoroutine("Instanciador");

        }
    }

}
