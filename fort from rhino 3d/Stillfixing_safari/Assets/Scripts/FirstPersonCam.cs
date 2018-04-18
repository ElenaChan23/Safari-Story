using UnityEngine;
using System.Collections;

public class FirstPersonCam : MonoBehaviour {

	public float speedH = 3.0f;
	public float speedV = 3.0f;

	private float yaw = 0.0f;
	private float pitch = 0.0f;

	public Camera cam;

	private void Start() {
		Cursor.visible = true;
	}

	void Update () {
		float oldpitch = pitch;
		yaw += speedH * Input.GetAxis("Mouse X");
		pitch -= speedV * Input.GetAxis("Mouse Y");


		if ((-80.0f < pitch) && (pitch < 80.0f)) {
			cam.transform.eulerAngles = new Vector3 (pitch, yaw, 0.0f);
		}  else {
			pitch = oldpitch;
		}
	}


}
