using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public abstract class PolyJumperAction : NetworkBehaviour
{
	public List<ActionRestriction> Restrictions;

	public abstract void RpcDoAction();
}

[Serializable]
public abstract class ActionRestriction : MonoBehaviour
{
	public abstract bool CanExecuteAction();
	public abstract void ActionWasExecuted();
}
