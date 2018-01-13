using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CooldownPlayerAction : PlayerAction
{
	public new List<KeyActionPair> ActionKeyValuePair;

	[Serializable]
	public new class KeyActionPair
	{
		public KeyCode KeyCode;
		public PolyJumperAction Action;
		public float Cooldown;
		public float CurrentCooldown;
		public bool CoolingDown;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer)
		{
			return;
		}
		for (int i = 0; i < ActionKeyValuePair.Count; i++)
		{
			var action = ActionKeyValuePair[i];
			if (Input.GetKeyDown(action.KeyCode) && !action.CoolingDown)
			{
				DoAction(i);
				action.CoolingDown = true;
				action.CurrentCooldown = action.Cooldown;
			}
			else
			{
				action.CurrentCooldown -= Time.deltaTime;
				action.CoolingDown = action.CurrentCooldown > 0;
			}
		}
	}
}
