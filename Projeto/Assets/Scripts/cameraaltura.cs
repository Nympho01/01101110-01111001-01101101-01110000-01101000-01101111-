using UnityEngine;
using System.Collections;

public class cameraaltura : MonoBehaviour {
	int m2,cont;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Mouse ScrollWheel") > 0f) 
		{
			if (cont < 15) {
				m2 = 2;
				transform.Translate (0, 0, m2);
				m2 = 0;
				cont++;
			}
		}
		if (Input.GetAxis("Mouse ScrollWheel") < 0f) 
		{
			if (cont != 0) {
				m2 = 2;
				transform.Translate (0, 0, -m2);
				m2 = 0;
				cont--;
			}
		}
	}
}