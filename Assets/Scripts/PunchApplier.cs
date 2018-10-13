using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchApplier : MonoBehaviour {

	public Transform owner;
	public Vector2 force;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		var direction = owner.transform.forward * force.x;
		direction.y = force.y;
		other.transform.GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse);
	}
}
