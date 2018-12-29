using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickAction : PolyJumperAction
{
	public Vector3 byAngles;
	public float inTime;
	private Quaternion fromAngle;
	private LockedRestriction restriction;


	public void Start()
	{
		fromAngle = transform.rotation;
		restriction = transform.GetComponent<LockedRestriction>();
	}

	public override void RpcDoAction()
	{
		Restrictions.Add(restriction);
		transform.GetComponentInChildren<PunchApplier>().enabled = true;
		StartCoroutine(RotateMe());
	}

	IEnumerator RotateMe()
	{
		var toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
		for (var t = 0f ; t < 1; t += Time.deltaTime / inTime)
		{
			transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
			yield return null;
		}
		finishUp();
	}

	private void finishUp()
	{
		transform.GetComponentInChildren<PunchApplier>().enabled = false;
		transform.rotation = fromAngle;
		Restrictions.Remove(restriction);
	}
}
