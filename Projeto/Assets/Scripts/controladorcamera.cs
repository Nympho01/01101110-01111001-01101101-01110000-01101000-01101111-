using UnityEngine;
using System.Collections;

public class controladorcamera : MonoBehaviour {
	int altura ;
	int largura;
	public int m;
	public Quaternion vetor;
	public Vector3 vetorposicao;
	bool trava;

	// Use this for initialization
	void Start () {
		largura = Screen.width;
		altura = Screen.height;
		vetor = transform.rotation;
		trava = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("f"))
		{
			print ("F");
			if (trava == true) {
				trava = false;
			}
			else if (trava == false) {
				trava = true;
				transform.localPosition = vetorposicao;
			}
		}
		if (trava == true) {
			transform.rotation = vetor;
		}
		if (trava == false) {
			if (transform.localPosition.x >= -23.44f) {
				if (Input.mousePosition.x == 0) {
					m = 5;
					transform.Translate (-m, 0, 0);
					m = 0;
				}
			}
			if (transform.localPosition.z >= -137.6) {
				if (Input.mousePosition.y <= 3) {
					m = 5;			
					transform.Translate (0, -m, 0);
					m = 0;
				}
			}
			if (transform.localPosition.x <= 294.3) {
				if (Input.mousePosition.x >= largura - 10) {
					m = 5;
					transform.Translate (m, 0, 0);
					m = 0;
				}
			}
			if (transform.localPosition.z <= 175.6) {
				if (Input.mousePosition.y >= altura) {
					m = 5;			
					transform.Translate (0, m, 0);
					m = 0;
				}
			}
			}
}
}