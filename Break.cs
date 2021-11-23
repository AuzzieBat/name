using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    public AudioSource SFX;

    public BoxCollider2D gB;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            SFX.Play();
            Destroy(gB);
            Invoke("vanish", 2);
        }
    }

    public void vanish()
    {
        Destroy(gameObject);
    }

}
