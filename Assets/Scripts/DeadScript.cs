using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadScript : MonoBehaviour
{
    public GameObject DeadPrefab;
    public Transform Canvas;

    public GameObject ThanksPrefab;
    public void OnTriggerEnter2D()
    {
        Instantiate(DeadPrefab, Canvas);
        Time.timeScale = 0f;
    }

    public void OnBtnClick()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnBtnClickFriends()
    {
        Instantiate(ThanksPrefab, transform.parent.parent);
        GameObject.Destroy(transform.parent.gameObject);
    }
}
