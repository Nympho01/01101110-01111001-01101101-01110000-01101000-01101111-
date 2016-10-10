using UnityEngine;
using System.Collections;

public class controladorcamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w"))
		{
			transform.Translate (0,1,0);
		}
		if(Input.GetKey("a"))
		{
			transform.Translate (-1,0,0);
		}
		if(Input.GetKey("s"))
		{
			transform.Translate (0,-1,0);
		}
		if(Input.GetKey("d"))
		{
			transform.Translate (1,0,0);
		}
}
}