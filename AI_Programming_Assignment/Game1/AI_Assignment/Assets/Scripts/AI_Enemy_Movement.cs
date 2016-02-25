using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AI_Enemy_Movement : MonoBehaviour {

	public Transform [] points; 
	private int destPoint = 0;
	private NavMeshAgent agent;
	public Transform playerLocation;
	//public bool detection = false;
	public bool detection = false;
	public Home protection;



	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		//Disabling auto braking enables continuous movement between poimts. 
		agent.autoBraking = false;
			GotoNextPoint();
	}

	void GotoNextPoint() {
	//Returns if no points set up
		if (points.Length == 0)
			return;

		//Sets agent to go to currently selected destination.
		agent.destination = points[destPoint].position;

		//Chooses next point in array as destination cycling to start if necessary
		destPoint = (destPoint + Random.Range(0, points.Length)) % points.Length;
	}

	void Update () {
		//Choose next destination point when agent gets close to current one. 

		if (detection == true) {
			if (protection.safe== false) {
				agent.destination = playerLocation.position;
				Debug.Log ("DETECTED");
			}
		}

			if (detection == true) {
				if (protection.safe == true) {
					GotoNextPoint ();
					Debug.Log ("He's Home Now");
				}

		} else {
			
			if (agent.remainingDistance < 0.5f) {
				GotoNextPoint ();
				Debug.Log ("LOST HIM!");
			}
		}
	}

		






	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			detection = true;
			Debug.Log ("Detected");
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.tag == "Player") {
			detection = false;
			Debug.Log ("UnDetected");
		}
	}
}


