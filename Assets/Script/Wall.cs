using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {
	
	//private float WallForce;
	public bool move;
	
	public float forca;
	
	public string collide;
	
	// Use this for initialization
	void Start () {
		move = true;
//		rigidbody.velocity
		forca = Random.Range(30,30);
	}
	
	// Update is called once per frame
	void Update () {
		if(move){
			Grunt g = GetComponentInChildren<Grunt>();
			float forcaTotal = forca - g.GetForca();
			
			//rigidbody.AddForce(-transform.forward * forcaTotal);
			rigidbody.velocity = -transform.forward * forcaTotal;
			//TODO: Adicionar som das paredes se mechendo.
		}
		else{
			rigidbody.velocity = new Vector3();
			rigidbody.constraints = RigidbodyConstraints.FreezeAll;
		}
	}
	
	void OnCollisionStay(Collision collission) {
    // Check if the collider we hit has a rigidbody
    // Then apply the force
		
		foreach(var contact in collission.contacts){
			if(contact.thisCollider.name != "MagoR" && contact.otherCollider.name != "MagoR")
				move = false;
			//else{
			//	Collider collider = contact.thisCollider.name == "Mago" ? contact.thisCollider : contact.otherCollider;
				//GameObject controller = collider.gameObject;
				//Vector3 point = contact.point + rigidbody.velocity;
			//	Debug.Log(collider.gameObject.transform.position.x);
				//controller.transform.position = point;
			//}/
			//collide = contact.thisCollider.name + " -> " + contact.otherCollider.name; 
			//Debug.Log(collide);
			//TODO: Grunt caindo
		}
		
	}
}
