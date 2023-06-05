using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrushDetector : MonoBehaviour
{
    [SerializeField] float restartDelay = 0.5f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Snow")
        {
            Invoke("RestartLevel", restartDelay);
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
