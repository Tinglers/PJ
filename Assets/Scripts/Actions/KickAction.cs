using System.Collections;
using UnityEngine;

[RequireComponent(typeof(LockedRestriction))]
public class KickAction : PolyJumperAction
{
	public Vector3 byAngles;
	public float inTime;
	private Quaternion fromAngle;
	private LockedRestriction restriction;
	private PunchApplier puncher;


	public void Start()
	{
		restriction = transform.GetComponent<LockedRestriction>();
		puncher = transform.GetComponentInChildren<PunchApplier>();
	}

	public override void RpcDoAction()
	{
		Restrictions.Add(restriction);
		puncher.enabled = true;
		StartCoroutine(RotateMe());
	}

	IEnumerator RotateMe()
	{
		fromAngle = transform.localRotation;
		var toAngle = Quaternion.Euler(transform.localEulerAngles + byAngles);
		for (var t = 0f ; t < 1; t += Time.deltaTime / inTime)
		{
			transform.localRotation = Quaternion.Slerp(fromAngle, toAngle, t);
			yield return null;
		}
		FinishUp();
	}

	private void FinishUp()
	{
		puncher.enabled = false;
		transform.localRotation = fromAngle;
		Restrictions.Remove(restriction);
	}
}
