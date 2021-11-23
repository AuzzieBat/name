using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public int Respawn;

    public void Reload()
    {
        SceneManager.LoadScene(Respawn);
    }
}
