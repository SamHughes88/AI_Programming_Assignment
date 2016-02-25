using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class Goal : MonoBehaviour {
	void OnTriggerEnter (Collider other)
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);

	}


		
}
