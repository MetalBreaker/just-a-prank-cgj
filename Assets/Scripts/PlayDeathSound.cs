using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayDeathSound : MonoBehaviour
{
    public void OnTriggerEnter2D()
    {
        GetComponent<AudioSource>().enabled = true;
    }
}
