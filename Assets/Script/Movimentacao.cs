using UnityEngine;
using System.Collections;

public class Movimentacao : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	 public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
	public float turnSpeed = 60F;
    private Vector3 moveDirection = Vector3.zero;
	
	public ControllerColliderHit hit;
	
	public bool andando,frente,tras;
	
	public GameObject colisor;
	
	Quaternion rot;
    void Update() {
		
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded) {
			transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);
			
			if(andando){
            	if(frente){
					moveDirection = new Vector3(0, 0, 1);
				}
				if(tras){
					moveDirection = new Vector3(0, 0, -1);
				}
			}else{
				moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
			}
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

			
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
            
        }
        moveDirection.y -= gravity * Time.deltaTime;
		
		//if(colisor != null)
		//	moveDirection += colisor.rigidbody.velocity;
			controller.Move(moveDirection * Time.deltaTime);
		
	}
	
	
}
