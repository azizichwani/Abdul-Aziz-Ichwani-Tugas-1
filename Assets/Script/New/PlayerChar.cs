using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChar : BaseCharacter, IRaycastable
{
    private GameControl Gameover;

    void Start()
    {
        Gameover = FindObjectOfType<GameControl>();
    }

    //public GameObject gameover;
    protected override void Update()
    {
        base.Move();

        if(transform.position.y <= -5)
        {
            Destroy(gameObject);
        }
    }

    public void Clickable()
    {
        Gameover.over();
        Debug.Log("Klik");
    }
}
