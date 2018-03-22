using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

    public Text text;
    public float fallSpeed;

    private void Start()
    {
        fallSpeed = Random.Range(1f, 2f);
    }

    public void SetWord (string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
    }

	private void OnTriggernEnter2D (Collider2D collision){
		if (collision.gameObject.tag == "Lava") {
			RemoveWord ();
		}
	}

}
