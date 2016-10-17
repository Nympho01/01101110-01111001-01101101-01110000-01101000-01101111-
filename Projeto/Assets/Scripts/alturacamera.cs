using UnityEngine;
using System.Collections;

public class scrollmouse : MonoBehaviour {
	int m2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Mouse ScrollWheel") != 0f) 
		{
			m2 = 2;
			transform.Translate (0,m2,0);
			m2 = 0;
		}
	}
}
