using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private bool levelCompleted = false;
    public AudioSource BGM;
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            levelCompleted = true;
            Invoke("CompleteLevel", 2f);
        }
    }
    private void CompleteLevel()
    {
        BGM.Stop();
        SceneManager.LoadScene("MenuHub");
    }
}

