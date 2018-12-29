using System.Linq;

public class ChanneledAction : PolyJumperAction
{
	private bool channeling;
	public PolyJumperAction actionToChannel;

	public override void RpcDoAction()
	{
		channeling = !channeling;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (channeling)
		{
			actionToChannel.TryDoAction();
		}
	}
}
