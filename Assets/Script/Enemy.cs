using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour 
{

    private Score skor;
    // Start is called before the first frame update
    void Start()
    {
        skor = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        skor.addScore();
        Destroy(gameObject);
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Batas"))
        {
            Destroy(gameObject);
        }
    }
}
