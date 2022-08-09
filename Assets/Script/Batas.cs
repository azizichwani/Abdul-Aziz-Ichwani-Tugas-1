using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batas : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            GameControl.health -= 1;
        }
    }
}
