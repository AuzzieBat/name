using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public int Respawn;
    public AudioSource SFX;
    public ParticleSystem particleSystem;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SFX.Play();
            explode();
            Invoke("Break", 2);
            Invoke("Death", 1);
        }
        else
        {
            SFX.Play();
            explode();
            Invoke("Break", 2);
        }

    }
    void Death()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Break()
    {
        Destroy(gameObject);
    }

    public void explode()
    {
        particleSystem.Play();
    }
}
