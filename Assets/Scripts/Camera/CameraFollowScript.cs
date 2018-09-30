using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
	public GameObject objectToFollow;

	public float speed = 2.0f;
	private Vector3 offset;

	void Start()
	{
		offset = transform.position - objectToFollow.transform.position;
	}

	void Update()
	{
		this.transform.position = objectToFollow.transform.position + offset;
	}

}
