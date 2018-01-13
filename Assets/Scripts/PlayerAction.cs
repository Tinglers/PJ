using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerAction : NetworkBehaviour
{
	public List<KeyActionPair> ActionKeyValuePair;

	[Serializable]
	public class KeyActionPair
	{
		public KeyCode KeyCode;
		public PolyJumperAction Action;
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
			if (Input.GetKeyDown(action.KeyCode))
			{
				DoAction(i);
			}
		}
	}

	public void DoAction(int action)
	{
		ActionKeyValuePair[action].Action.RpcDoAction();
		if (Network.isClient)
		{
			CmdDoAction(action);
		}
	}

	[Command]
	public void CmdDoAction(int action)
	{
		ActionKeyValuePair[action].Action.RpcDoAction();
	}
}
