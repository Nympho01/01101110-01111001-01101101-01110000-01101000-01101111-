using UnityEngine;
using System.Collections;

public class controladorcamera : MonoBehaviour {
	int altura ;
	int largura;
	public int m;

	// Use this for initialization
	void Start () {
		largura = Screen.width;
		altura = Screen.height;
	}
	
	// Update is called once per frame
	void Update () {
		print ("X "+Input.mousePosition.x+"Y "+Input.mousePosition.y);
		if (Input.mousePosition.x == 0) {
			m = 5;
			transform.Translate (-m, 0, 0);
			m = 0;
		}
		if (Input.mousePosition.y <= 3) {
			m = 5;			
			transform.Translate (0, -m, 0);
			m = 0;
		}
		if (Input.mousePosition.x >= largura-10) {
			m = 5;
			transform.Translate (m, 0, 0);
			m = 0;
		}
		if (Input.mousePosition.y >= altura) {
			m = 5;			
			transform.Translate (0, m, 0);
			m = 0;
		}
}
}