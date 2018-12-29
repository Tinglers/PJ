﻿using UnityEngine;

public class GroundedRestriction : ActionRestriction
{
	public override void ActionWasExecuted()
	{
		//doe niks
	}

	public override bool CanExecuteAction()
	{
		return Physics.Raycast(transform.position, -Vector3.up, 1.03f);
	}
}
