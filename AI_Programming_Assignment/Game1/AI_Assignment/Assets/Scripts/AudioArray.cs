using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class AudioArray : MonoBehaviour {
	public AudioClip [] snake;

	void Start () {
		
		{
			GetComponent<AudioSource>().clip = snake [Random.Range (0, snake.Length)];
			GetComponent<AudioSource>().Play ();
		}
	}

}
