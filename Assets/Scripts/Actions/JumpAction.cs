using UnityEngine;

public class JumpAction : PolyJumperAction
{
	public Vector3 JumpVector;
	

	public override void RpcDoAction()
	{
		transform.GetComponentInParent<Rigidbody>().AddRelativeForce(JumpVector, ForceMode.Impulse);
	}
}
