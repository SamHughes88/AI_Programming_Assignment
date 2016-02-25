using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {

	public Transform goal; 
	public Transform home;
	public bool playerDetection = false;
	public Home safety;
	private float timer = 0f;
	public float waitTime = 10f;



	void Update()	{
		
		if (safety.safe == false) {
			if (playerDetection == true) {
				NavMeshAgent agent = GetComponent<NavMeshAgent> ();
				agent.destination = home.position;
			}
			else{
				NavMeshAgent agent = GetComponent<NavMeshAgent> ();
				agent.destination = goal.position;
			}
			if (safety.safe == true){
				timer += Time.deltaTime;
				if (timer >= waitTime) {
				NavMeshAgent agent = GetComponent<NavMeshAgent> ();
				agent.destination = goal.position;
				timer = 0;
			if (timer < waitTime) {
					agent.destination = home.position;
				}
			}
			}
		}

		}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy") {
			playerDetection = true;
			Debug.Log ("Run Away!");
		} 
	}

	void OnTriggerExit (Collider other)
	{
		if (other.tag == "Enemy"){
			playerDetection = false;
			Debug.Log ("Phew");
		}
	}

}


