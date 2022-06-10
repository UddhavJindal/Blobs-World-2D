using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour
{
    public AudioClip deathClip;
    public AudioClip fireClip;
    public Text CoinTXT;
    public Text EggTXT;
    public GameObject deathMenu;

    void Start()
    {
        deathMenu.gameObject.SetActive(false);
        GetComponent<AudioSource>().clip = fireClip;
        GetComponent<AudioSource>().Play();

    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().clip = deathClip;
            GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().clip = fireClip;
            GetComponent<AudioSource>().Stop();

            deathMenu.gameObject.SetActive(true);
        }
    }
}
