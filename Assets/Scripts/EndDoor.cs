using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDoor : MonoBehaviour
{
    public AudioClip door;
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().clip = door;
            GetComponent<AudioSource>().Play();
        }
    }
}
