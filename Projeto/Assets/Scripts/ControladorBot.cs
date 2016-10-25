﻿using UnityEngine;
using System.Collections;

public class ControladorBot : MonoBehaviour {
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
		print (collision.collider.name);
		if (collision.collider.name == "target1Bot")
		{
			agent.SetDestination (target[1].transform.position);
		}
		else if (collision.collider.name == "target2Bot")
		{
			agent.SetDestination (target[2].transform.position);
		}
		else if (collision.collider.name == "target3Bot")
		{
			agent.SetDestination (target[3].transform.position);
		}
	}	
}
