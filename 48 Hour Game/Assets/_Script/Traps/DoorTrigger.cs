using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

	public MovingWall movingWall;
	public MovingWall movingWall2;
	public bool entered = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.CompareTag("Player"))
		{
			movingWall.hasEntered = true;
			movingWall2.hasEntered = true;
			entered = true;
		}
	}
}
