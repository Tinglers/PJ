using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RotationScript : NetworkBehaviour {

	public Vector3 LookRotationFactor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer) return;
		transform.Rotate(0, Input.GetAxis("Mouse X") * LookRotationFactor.x, Input.GetAxis("Mouse Y") * LookRotationFactor.y, Space.World);
	}
}
