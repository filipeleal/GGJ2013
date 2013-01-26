using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {
	
	//private float WallForce;
	private bool move;
	
	private float forca = 30f;
	
	public string collide;
	
	// Use this for initialization
	void Start () {
		move = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(move){
			Grunt g = GetComponentInChildren<Grunt>();
			float forcaTotal = forca - g.GetForca();
			//Debug.Log(forcaTotal);
			
			
			transform.Translate(-Vector3.forward * Time.deltaTime * forcaTotal/10);
			
			//TODO: Adicionar som das paredes se mechendo.
		}
	}
	
	void OnCollisionStay(Collision collission) {
    // Check if the collider we hit has a rigidbody
    // Then apply the force
		
		foreach(var contact in collission.contacts){
			if(contact.thisCollider.name == "Moving Wall" || contact.otherCollider.name == "Moving Wall")
				move = false;
			
			collide = contact.thisCollider.name + " -> " + contact.otherCollider.name; 
			//Debug.Log(collide);
			//TODO: Grunt caindo
		}
		
	}
}
