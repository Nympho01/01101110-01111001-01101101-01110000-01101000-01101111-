using UnityEngine;
using System.Collections;

public class Personagem : MonoBehaviour {
	public Animator animator;
	public Camera camera;
	public NavMeshAgent personagem;
	Vector3 target;
	// Use this for initialization
	void Start () {
		animator.SetBool ("idle", true);
		animator.SetBool ("walk", false);	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0))
		{
			Ray ray = camera.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) 
			{
				target = hit.point;
				animator.SetBool ("idle", false);
				animator.SetBool ("walk", true);	
				personagem.SetDestination (target);
			}
		}
	}
}
