using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour {

    WordDisplay display;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Word")
        {
            Debug.Log("Destroying Word!");
            display.RemoveWord();
        }
    }
}
