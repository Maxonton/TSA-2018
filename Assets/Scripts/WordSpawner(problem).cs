using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wordspawner : MonoBehaviour {

    public GameObject wordPrefab;
    public Transform wordCanvas;
	//public Transform[] SpawnPoint;

    public float ycoord =700f;

    public float minx = -300f;
    public float maxx = 300f;

	public WordDisplay SpawnWord()
    {
        float xcoord = Random.Range(minx, maxx);
        Vector3 topPosition = new Vector3(xcoord,ycoord);

//<<<<<<< HEAD
		GameObject wordObj = Instantiate(wordPrefab, topPosition, Quaternion.identity, wordCanvas);
//=======
        //GameObject wordObj = Instantiate(wordPrefab, topPosition, Quaternion.identity, wordCanvas);
//>>>>>>> 5521d808b93100be0a82297eb9e120c414a5055d
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        return wordDisplay;
    }


}
