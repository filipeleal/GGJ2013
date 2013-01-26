using UnityEngine;
using System.Collections;

public class asd : MonoBehaviour {
	
	public int i;
	public GameObject a;
	public Texture tex;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = new Vector3(transform.position.x ,transform.position.y+1 ,transform.position.z);
	
	}
}
