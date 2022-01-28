using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] private ParticleSystem dustEffect;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D other)
    {
        // Kan også bruke other.gameObject.tag
        if (other.collider.tag == "Ground")
        {
            dustEffect.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        // Kan også bruke other.gameObject.tag
        if (other.collider.tag == "Ground")
        {
            dustEffect.Stop();
        }
    }
}
