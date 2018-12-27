using UnityEngine;

public class JetpackAction : PolyJumperAction
{
	public Vector3 JumpVector;
	
	public override void RpcDoAction()
	{
		var rigidbody = transform.GetComponentInParent<Rigidbody>();
		rigidbody.AddForce(JumpVector - rigidbody.velocity, ForceMode.Acceleration);
	}
}
