using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelScript : MonoBehaviour
{

    public void OnTriggerEnter2D()
    {
        if (DialogueManager.Instance.DialogueCompleted)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            GetComponent<AudioSource>().enabled = true;
        }
    }
}
