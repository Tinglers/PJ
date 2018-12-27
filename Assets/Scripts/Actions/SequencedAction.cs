using System.Collections.Generic;
using UnityEngine;

public class SequencedAction : PolyJumperAction
{
	public List<PolyJumperAction> Sequence;
	public int CurrentAction = 0;
	
	public override void RpcDoAction()
	{
		if (Sequence[CurrentAction].TryDoAction())
		{
			CurrentAction++;
			CurrentAction %= Sequence.Count;
		}
	}

	public void ResetSequence()
	{
		CurrentAction = 0;
	}
}
