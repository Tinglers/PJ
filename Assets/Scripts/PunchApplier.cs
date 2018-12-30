using UnityEngine;

public class PunchApplier : MonoBehaviour {

	public Transform owner;
	public Vector2 force;
	// Use this for initialization
	void Start () {
		if (owner == null)
		{
			owner = transform.parent.parent;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!enabled) return;
		var direction = owner.transform.forward * force.x;
		direction.y = force.y;
		other.transform.GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse);
	}
}
