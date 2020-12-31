using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController cc;
	public float speed = 12f;

	void Start () {
		
	}
	

	void Update () {
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");

		Vector3 move = transform.right * x + transform.forward * z;

		cc.Move (move * speed * Time.deltaTime);
	}
}
