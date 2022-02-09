using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlat : MonoBehaviour
{
    private float time = 0.5f;
    public AudioClip glassClip;

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject, time);
            GetComponent<AudioSource>().clip = glassClip;
            GetComponent<AudioSource>().Play();
        }
    }
}
