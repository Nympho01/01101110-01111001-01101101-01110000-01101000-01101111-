using UnityEngine;
using System.Collections;

public class Instanciador : MonoBehaviour {


	public controlador controlador;
	public ControladorMid controladorMid;
	public ControladorBot controladorBot;
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
