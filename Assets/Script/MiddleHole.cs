using UnityEngine;
using System.Collections;

public class MiddleHole : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerStay(Collider collision){
	/*	foreach(var col in collision.contacts){
			if(col.thisCollider.gameObject == gameObject)
			{
				col.otherCollider.gameObject.rigidbody.velocity = new Vector3();
				col.otherCollider.gameObject.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
			}
		}*/
	}
}
