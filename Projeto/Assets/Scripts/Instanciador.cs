using UnityEngine;
using System.Collections;

public class Instanciador : MonoBehaviour {


	public controlador controlador,controladorMid,controladorBot;
	public GameObject[] vet,vetmid,vetbot;
	// Use this for initialization
	void Start () {
		controlador.target = vet;
		controladorMid.target = vetmid;
		controladorBot.target = vetbot;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
