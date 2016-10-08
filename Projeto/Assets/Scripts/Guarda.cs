﻿using UnityEngine;
using System.Collections;

public class Guarda : MonoBehaviour {
	public Animator animator;
	public NavMeshAgent agent;
	public GameObject[] target;


	void Start () {
		agent.SetDestination (target[0].transform.position);
		animator.SetBool ("inidle", false);
		animator.SetBool ("inwalk", true);
	}

	// Update is called once per fram
	void Update () {

	}
	void OnCollisionEnter(Collision collision)
	{
		print ("colidiu"+collision.collider.name);
		if (collision.collider.name == "target1")
		{
			agent.SetDestination (target[1].transform.position);
		}
		else if (collision.collider.name == "target2")
		{
			agent.SetDestination (target[2].transform.position);
		}
		else if (collision.collider.name == "target3")
		{

			agent.SetDestination (target[3].transform.position);
		}
		else if (collision.collider.name == "target4")
		{
			animator.SetBool ("inidle", false);
			animator.SetBool ("inwalk", true);
			agent.SetDestination (target[0].transform.position);
		}
	}	
}
