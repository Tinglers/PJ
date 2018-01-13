using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class HookAction : PolyJumperAction
{
	public GameObject hookPrefab;
	private GameObject hookGameObject;

	public Vector3 VelocityVector;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void RpcDoAction()
	{
		if (hookGameObject == null)
		{
			hookGameObject = (GameObject)Instantiate(hookPrefab, transform.position + transform.right, transform.rotation);
			var locVel = transform.InverseTransformDirection(hookGameObject.GetComponent<Rigidbody>().velocity);
			locVel.x = VelocityVector.x;
			locVel.y = VelocityVector.y;
			hookGameObject.GetComponent<Rigidbody>().velocity = transform.TransformDirection(locVel);
			NetworkServer.Spawn(hookGameObject);
			Destroy(hookGameObject, 2.0f);
		}
	}
}
