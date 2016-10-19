using UnityEngine;
using System.Collections;

public class controladorcamera : MonoBehaviour {
	int altura ;
	int largura;
	public int m;
	public Quaternion vetor;
	public Vector3 vetorposicao;
	bool trava;
	public GameObject player;
	Vector3 vet;

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
			if (trava == true) {
				trava = false;
			}
			else if (trava == false) {
				trava = true;
				vetorposicao.x=player.transform.position.x-10;
				vetorposicao.y=transform.position.y;
				vetorposicao.z=player.transform.position.z+10;
				transform.position = vetorposicao;
			}
		}
		if (trava == true) {
			transform.rotation = vetor;
			vet.x=player.transform.position.x-10;
			vet.y=transform.position.y;
			vet.z=player.transform.position.z+10;
			transform.position = vet;
		}
		if (trava == false) {
			if (transform.localPosition.x >= 8.9f) {
				if (Input.mousePosition.x == 0) {
					m = 5;
					transform.Translate (-m, 0, 0);
					m = 0;
				}
			}
			if (transform.localPosition.z >= 33.7f) {
				if (Input.mousePosition.y <= 3) {
					m = 5;			
					transform.Translate (0, -m, 0);
					m = 0;
				}
			}
			if (transform.localPosition.x <= 433f) {
				if (Input.mousePosition.x >= largura - 10) {
					m = 5;
					transform.Translate (m, 0, 0);
					m = 0;
				}
			}
			if (transform.localPosition.z <= 455.2f) {
				if (Input.mousePosition.y >= altura) {
					m = 5;			
					transform.Translate (0, m, 0);
					m = 0;
				}
			}
			}
}
}