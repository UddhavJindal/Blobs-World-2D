using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text CoinTXT;
    public Text EggTXT;
    public GameObject scoreMenu;
    public int score;
    public int eggs;
    public AudioClip door;
    public AudioClip coin;
    public AudioClip eggClip;
    // Start is called before the first frame update
    void Start()
    {
        CoinTXT.text = "Coins :";
        EggTXT.text = "Eggs :";

        scoreMenu.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        CoinTXT.text = "Coins :" + score;
        EggTXT.text = "Eggs :" + eggs;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Door")
        {
            GetComponent<AudioSource>().clip = door;
            GetComponent<AudioSource>().Play();

            scoreMenu.gameObject.SetActive(true);

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Coin1")
        {
            score += 1;
            GetComponent<AudioSource>().clip = coin;
            GetComponent<AudioSource>().Play();
        }
        if (other.gameObject.tag == "Egg5")
        {
            eggs += 5;
            GetComponent<AudioSource>().clip = eggClip;
            GetComponent<AudioSource>().Play();
        }

        if (other.gameObject.tag == "Fire")
        {
            Destroy(gameObject);
        }
    }
}
