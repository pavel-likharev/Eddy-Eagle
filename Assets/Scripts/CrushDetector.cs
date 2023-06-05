using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrushDetector : MonoBehaviour
{
    [SerializeField] float restartDelay = 0.5f;
    [SerializeField] ParticleSystem crushEffect;
    [SerializeField] AudioClip crushSound;

    bool isCrush = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Snow" && !isCrush)
        {
            isCrush = true;
            GetComponent<PlayerController>().DisableControls();
            crushEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crushSound);
            Invoke("RestartLevel", restartDelay);
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
