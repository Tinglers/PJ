using UnityEngine;
using UnityEngine.Networking;

public class JumpAction : PolyJumperAction
{
	public Vector3 JumpVector;
	
	[ClientRpc]
	public override void RpcDoAction()
	{
		GetComponent<Rigidbody>().AddForce(JumpVector, ForceMode.Impulse);
	}
}
