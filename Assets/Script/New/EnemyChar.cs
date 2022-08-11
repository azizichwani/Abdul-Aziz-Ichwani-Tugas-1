using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChar : BaseCharacter,IRaycastable
{
    private Score skor;
    
    void Start()
    {
        skor = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Move();

        if(transform.position.y <= -5)
        {
            GameControl.health -=1;
            Destroy(gameObject);
        }
    }

    public void Clickable()
    {
        skor.addScore();
        Destroy(gameObject);
        Debug.Log("klik");
    }
}
