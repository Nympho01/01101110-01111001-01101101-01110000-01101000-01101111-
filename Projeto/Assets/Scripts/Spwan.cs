using UnityEngine;
using System.Collections;

public class Spwan : MonoBehaviour {

	public GameObject minion;
	float tempo;
	int cont=0;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Minion ();
	}
	public void Minion()
	{
		tempo += Time.deltaTime;
		if(tempo>=2&&cont<5)
		{
			Instantiate(minion,transform.position,transform.rotation);
			tempo = 0;
			cont++;
		}
	}
}
