using UnityEngine;
using System.Collections;


public class Personagem : MonoBehaviour {


	public Animator animator;
	public string estado="inidle";
	public void PlayAnimation(string estado)
	{
		switch (estado) 
		{
		case "inidle":
			{
				StopAnimations ();
				animator.SetBool ("inidle", true);
			}
			break;
		case "inwalk":
			{
				StopAnimations ();
				animator.SetBool ("inwalk", true);
			}
			break;
		}
	}
	void StopAnimations()
	{
			animator.SetBool (3, false);
	}

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Q)) {
			PlayAnimation ("inidle");
		}
		if (Input.GetKey (KeyCode.W)) {
			PlayAnimation ("inwalk");
		}
	}
}
