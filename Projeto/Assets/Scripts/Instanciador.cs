using UnityEngine;
using System.Collections;

public class Instanciador : MonoBehaviour {


	public controlador controlador;
	public GameObject[] vet;
	// Use this for initialization
	void Start () {
		controlador.target = vet;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
