using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public abstract class PolyJumperAction : NetworkBehaviour
{
	public abstract void RpcDoAction();
}
