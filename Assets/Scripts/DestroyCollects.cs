using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollects : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
