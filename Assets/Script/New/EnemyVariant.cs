using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVariant : BaseCharacter, IRaycastable
{
    private Score skor;
    [SerializeField] protected float speedZ;
    float dirX;
    float timer;
    float directInterval = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        skor = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Move();
	Zigzag();

	if(transform.position.y <= -5)
        {
            GameControl.health -=1;
            Destroy(gameObject);
        }
    }

    void Zigzag()
    {
        ConstraintPos();

        timer += Time.deltaTime;
        if(timer > directInterval)
        {
            RandomDirection();

            transform.Translate(new Vector3 ( dirX, 0,0 ) * (speedZ * Time.deltaTime)*25);

            timer -= directInterval;
        } 
    }

    void RandomDirection()
    {
        int rndDirect = Random.Range(0,3);
        switch (rndDirect)
        {
            case 0:
                dirX = 0f;
                break;
            case 1:
                dirX = 3f;
                break;
            case 2:
                dirX = -3f;
                break;
        }
    }

    void ConstraintPos()
    {
        Vector3 posDefault = transform.position;

        if(transform.position.x >= 4f)
        {
            transform.position = new Vector3(4f, posDefault.y, posDefault.z);
        }

        if(transform.position.x <= -4f)
        {
            transform.position = new Vector3(-4f, posDefault.y, posDefault.z);
        }
    }

    public void Clickable()
    {
        skor.addScore();
        Destroy(gameObject);
        Debug.Log("klik");
    }
}
