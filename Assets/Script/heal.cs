using UnityEngine;
using System.Collections;

public class heal : MonoBehaviour {
	Collider[] colliders;
	Grunt grunt;
	// Update is called once per frame
	void Update () {
		colliders = Physics.OverlapSphere(transform.position,2F);
		if(colliders.Length>0){
			foreach(Collider col in colliders){
				grunt = col.gameObject.GetComponent<Grunt>();
				if( grunt != null){
				
					//mostra display H
					//libera possibilidade de apertar o H
					
					return;
				}else{
					//bloqueia o H
				
				}
				
			}
		}
		
	}
	
}
