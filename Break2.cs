using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break2 : MonoBehaviour
{
    public AudioSource SFX;

    public AudioSource SFX2;

    private void Awake()
    {
        SFX.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SFX2.Play();
        Invoke("Break", 2);
        SFX.Stop();
    }

    void Break()
    {
        Destroy(gameObject);
    }
}
