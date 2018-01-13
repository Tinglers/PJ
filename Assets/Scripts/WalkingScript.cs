using UnityEngine;
using UnityEngine.Networking;

public class WalkingScript : NetworkBehaviour
{


	public Vector3 MovementSpeed;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer) return;
		var x = Input.GetAxis("Vertical") * Time.deltaTime * MovementSpeed.x;
		var z = Input.GetAxis("Horizontal") * Time.deltaTime * MovementSpeed.z;
		transform.Translate(x, 0, -z);
	}
}
