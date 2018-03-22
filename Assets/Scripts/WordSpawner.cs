using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

    public GameObject wordPrefab;
    public Transform wordCanvas;

    public float ycoord =700f;

    public float minx = -300f;
    public float maxx = 300f;

	public WordDisplay SpawnWord()
    {
        float xcoord = Random.Range(minx, maxx);
        Vector3 topPosition = new Vector3(xcoord,ycoord);

        GameObject wordObj = Instantiate(wordPrefab, topPosition, Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        return wordDisplay;
    }


}
