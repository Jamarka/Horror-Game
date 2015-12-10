using UnityEngine;
using System.Collections;

public class SpikeWallDetection : MonoBehaviour {

	public MovingWall movingWall;
	public bool hasHit = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.collider.CompareTag("SpikedWall"))
		{
			movingWall.hasHitWall = true;
			hasHit = true;
			Application.LoadLevel(0);
		}
	}
}
