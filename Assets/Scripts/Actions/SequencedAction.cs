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
		Restrictions = Sequence[CurrentAction].Restrictions; //niet zo netjes, dit is hier omdat de sequence zelf geen restrictions heeft
		Sequence[CurrentAction].RpcDoAction();
		CurrentAction++;
		CurrentAction %= Sequence.Count;
		Restrictions = Sequence[CurrentAction].Restrictions;
	}

	public void ResetSequence()
	{
		CurrentAction = 0;
		Restrictions = Sequence[CurrentAction].Restrictions;
	}
}
