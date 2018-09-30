using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositioningBehaviour : MonoBehaviour {

	public Transform Target;
	public Vector3 offset;
	public int movementSpeed;
	public Vector3 LookRotationFactor;

	public Vector3 destination;
	public Vector3 rotation;

	// Use this for initialization
	void Start () {
		destination = transform.position;
	}

	// Update is called once per frame
	void Update()
	{
		destination = CalculateDestination();
		rotation = CalculateRotation();
		transform.position = Vector3.Lerp(transform.position, destination, Time.deltaTime * (100 / movementSpeed));
	}

	private Vector3 CalculateRotation()
	{
		transform.LookAt(Target.up + new Vector3(0, 1));
		return new Vector3();

	}

	private Vector3 CalculateDestination()
	{
		return Target.position - (Target.forward * offset.x) + (Target.up * offset.y); // throw new NotImplementedException();
	}
}
