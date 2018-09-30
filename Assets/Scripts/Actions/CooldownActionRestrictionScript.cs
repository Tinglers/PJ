using UnityEngine;

public class CooldownActionRestrictionScript : ActionRestriction {

	public float Cooldown;
	private float CurrentCooldown;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		CurrentCooldown -= Time.deltaTime;
	}

	public override bool CanExecuteAction()
	{
		return !(CurrentCooldown > 0);
	}

	public override void ActionWasExecuted()
	{
		CurrentCooldown = Cooldown;
	}
}
