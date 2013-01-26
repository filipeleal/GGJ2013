using UnityEngine;
using System.Collections;

public class Stamina : MonoBehaviour {
	
	public GameObject GruntObj;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Grunt g = GruntObj.GetComponent<Grunt>();
		
		//Debug.Log(g.GetStamina());
		if(g !=null)
			transform.localScale = new Vector3(g.GetStamina()/100,transform.localScale.y,transform.localScale.z);
	}
}
