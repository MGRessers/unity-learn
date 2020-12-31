using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

	public float mouseSensitivity = 100f;

	public Transform plrBody;

	float xRotation = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float MouseX = Input.GetAxis ("Mouse X");
		float MouseY = Input.GetAxis ("Mouse Y");

		xRotation -= MouseY;
		xRotation = Mathf.Clamp (xRotation, -90f, 90f);

		transform.localRotation = Quaternion.Euler (xRotation, 0f, 0f);
		plrBody.Rotate (Vector3.up * MouseX);

	}
}
