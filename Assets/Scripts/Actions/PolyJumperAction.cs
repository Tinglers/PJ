﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class PolyJumperAction : MonoBehaviour
{
	public List<ActionRestriction> Restrictions;
	public abstract void RpcDoAction();

	public bool TryDoAction()
	{
		if (Restrictions.All(r => r.CanExecuteAction()))
		{
			RpcDoAction();
			Restrictions.ForEach(r => r.ActionWasExecuted());
			return true;
		}
		return false;
	}
}

[Serializable]
public abstract class ActionRestriction : MonoBehaviour
{
	public abstract bool CanExecuteAction();
	public abstract void ActionWasExecuted();
}
