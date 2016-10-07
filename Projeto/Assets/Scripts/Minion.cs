using UnityEngine;
using System.Collections;

public class Minion : MonoBehaviour {

	float v = 0.001f;
	public bool colisao = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (colisao == false) {
			transform.Translate (-v, 0, 0);
		} 
	}

	void OnCollisionEnter(Collision collision)
	{
		colisao = true;
	}
	void OnCollisionExit(Collision collision)
	{
		colisao = false;
	}
}
