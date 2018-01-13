using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SequencedAction : PolyJumperAction
{
	public List<PolyJumperAction> Sequence;
	private int CurrentAction = 0;
	
	public override void RpcDoAction()
	{
		Sequence[CurrentAction].RpcDoAction();
		CurrentAction++;
		CurrentAction %= Sequence.Count;
	}
}
