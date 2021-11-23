using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WirelessBreak : MonoBehaviour
{
    public Rigidbody2D yes;

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(yes);

    }
}


