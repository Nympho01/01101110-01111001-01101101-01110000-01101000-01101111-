using UnityEngine;
using System.Collections;

public class controlador : MonoBehaviour {
	public Animator animator;
	public NavMeshAgent agent;
	public GameObject[] target;
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		agent.SetDestination (target[0].transform.position);
		if (agent.velocity.z>0) {
			print ("q");
			animator.SetBool ("inidle", false);
			animator.SetBool ("inwalk", true);
		}
		else if (Input.GetKey (KeyCode.W)) {
			print ("w");
			animator.SetBool ("inwalk", false);
			animator.SetBool ("inidle", true);
		}
	}
}
