using UnityEngine;
using System.Collections;

public class Home : MonoBehaviour {
	public bool safe = false;
	public Home safeNow;


	void OnTriggerEnter (Collider other){
		if (other.tag == "Player") {
			safe = true;
		}
	}
	void OnTriggerExit (Collider other){
		if (other.tag == "Player") {
	
			safe = false;
		}
	}
		
}
