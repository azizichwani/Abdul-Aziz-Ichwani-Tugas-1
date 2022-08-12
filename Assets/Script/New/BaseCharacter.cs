using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharacter : MonoBehaviour
{
    [SerializeField] protected float speed;

    // Update is called once per frame
    protected virtual void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        transform.Translate (speed * Vector2.down * Time.deltaTime);
    }
}
