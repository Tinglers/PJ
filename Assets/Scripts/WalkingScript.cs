using UnityEngine;
using UnityEngine.Networking;

public class WalkingScript : NetworkBehaviour
{


	public float zMovementSpeed;

	public float xMovementSpeed;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer) return;
		var x = Input.GetAxis("Vertical") * Time.deltaTime * xMovementSpeed;
		var z = Input.GetAxis("Horizontal") * Time.deltaTime * zMovementSpeed;
		transform.Translate(x, 0, -z);
	}
}
