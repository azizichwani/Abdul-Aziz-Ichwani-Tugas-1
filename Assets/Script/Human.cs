using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    private GameControl Gameover;

    // Start is called before the first frame update
    void Start()
    {
            Gameover = FindObjectOfType<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        Gameover.over();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Batas"))
        {
            Destroy(gameObject);
        }
    }
}
