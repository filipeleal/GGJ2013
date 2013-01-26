using UnityEngine;
using System.Collections;

public class ControleVelocidade : MonoBehaviour {

	float tempo = 0;
	float dif = 1F;
	public Movimentacao mov;
	
	// Update is called once per frame
	void Update () {
		
	if(Input.GetButtonDown("Vertical")){
		
			if(Input.GetAxis("Vertical")>0)
			{
				mov.frente = true;
				mov.tras=false;
			}else{
				mov.frente = false;
				mov.tras=true;
			}
			if(Time.time <	 tempo + dif)
			{
				mov.speed++;
				mov.andando = true;
			}
			else
			{	
				mov.speed = 6.0F;
				
			}
			tempo = Time.time;
			
		}
		
	
		
		if(mov.andando && Time.time > tempo + dif/4 ) {
				
				mov.andando = false;
				mov.speed = 6.0F;
			}
		
	}
}
