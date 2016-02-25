using UnityEngine;
using System.Collections;

public class BGMusic : MonoBehaviour {

	GameObject[] musicObject;
	// Use this for initialization
	void Start () {
		musicObject = GameObject.FindGameObjectsWithTag ("GameMusic");
		if (musicObject.Length == 1) {
			GetComponent<AudioSource>().Play ();
		} else {
			for (int i = 1; i < musicObject.Length; i++) {
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad (this.gameObject);
	}
}
