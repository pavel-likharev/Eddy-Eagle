using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowEffect;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Snow")
        {
            snowEffect.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Snow")
        {
            snowEffect.Stop();
        }
    }
}
