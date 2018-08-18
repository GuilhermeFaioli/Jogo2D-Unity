using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tinta : MonoBehaviour
{
    public float speed;
    private float alpha;
    private float red;
    SpriteRenderer _renderer;

    // Use this for initialization
    void Start()
    {
        _renderer = this.GetComponent<SpriteRenderer>();
        _renderer.color = new Color(red, red, alpha);
    }

    // Update is called once per frame
    void Update()
    {
       _renderer.color = new Color(red, red, alpha-=speed*Time.deltaTime);
        if (alpha <= 0)
        {
            Destroy(gameObject);
        }

    }

    public void SetColor(float _red, float _alpha)
    {
        red = _red;
        alpha = _alpha;
    }

}