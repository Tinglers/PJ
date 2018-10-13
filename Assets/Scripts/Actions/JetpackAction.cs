using UnityEngine;
using UnityEngine.Networking;

public class JetpackAction : PolyJumperAction
{
	public Vector3 JumpVector;
	
	[ClientRpc]
	public override void RpcDoAction()
	{
		var rigidbody = GetComponent<Rigidbody>();
		rigidbody.AddForce(JumpVector - rigidbody.velocity, ForceMode.Acceleration);
	}
}
