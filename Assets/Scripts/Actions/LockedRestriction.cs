using UnityEngine;

public class LockedRestriction : ActionRestriction
{
	public override void ActionWasExecuted()
	{
		//doe niks
	}

	public override bool CanExecuteAction()
	{
		//Debug.Log("was locked");
		return false;
	}
}
