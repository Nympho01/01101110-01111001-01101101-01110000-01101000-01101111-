using UnityEngine;
using System.Collections;

public class controladorcamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y"),0);

}
}