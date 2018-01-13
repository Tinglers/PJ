using UnityEngine;

public class LogAction : PolyJumperAction
{

	public string logText;

	public override void RpcDoAction()
	{
		Debug.Log(logText);
	}
}
