using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedRestriction : ActionRestriction {

	public Transform trigger;
	public override void ActionWasExecuted()
	{
		//doe niks
	}

	public override bool CanExecuteAction()
	{
		return Physics.Raycast(transform.position, -Vector3.up, 1.03f);
	}
}
