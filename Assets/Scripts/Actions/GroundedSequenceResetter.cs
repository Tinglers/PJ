using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GroundedSequenceResetter : MonoBehaviour {

	public List<SequencedAction> actions;

	public void OnTriggerEnter(Collider other)
	{
		actions.All(a =>
		{
			a.ResetSequence();
			return true;
		});
	}
}
