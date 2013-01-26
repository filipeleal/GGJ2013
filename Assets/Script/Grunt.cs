using UnityEngine;
using System.Collections;

public class Grunt : MonoBehaviour {
	
	private float stamina;
	
	private float forca;
	
	private float taxaDeRedutor;
	
	// Use this for initialization
	void Start () {
		stamina = 100;
		forca = 25;
		taxaDeRedutor = Random.Range(10,30);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(stamina);
		stamina -= taxaDeRedutor/100;
		if(stamina <= 0)
			stamina = 0;
	}
	
	public float GetStamina(){
		return stamina;
	}
	
	public float GetForca(){
		return forca * stamina / 100;	
	}
}
