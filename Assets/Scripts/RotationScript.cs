using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

	public Vector2 LookRotationFactor;
	public Vector2 ClampX;
	public Vector2 ClampY;
	public Space space = Space.World;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (!isLocalPlayer) return;
		transform.Rotate(Input.GetAxis("Mouse Y") * LookRotationFactor.y, Input.GetAxis("Mouse X") * LookRotationFactor.x, 0, space);
	}
}
