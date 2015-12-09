using UnityEngine;
using System.Collections;

public class MovingWall : MonoBehaviour {

	public bool hasEntered = false;
	public bool isRightWall = false;
	public bool hasHitWall = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (hasEntered == true && isRightWall)
		{
			if (hasHitWall == false)
			{
				transform.position = new Vector3( transform.position.x + 4 * Time.deltaTime, transform.position.y, transform.position.z);
			}
		}
		if (hasEntered == true && !isRightWall && hasHitWall == false)
		{
			if (hasHitWall == false)
			{
				transform.position = new Vector3( transform.position.x - 4 * Time.deltaTime, transform.position.y, transform.position.z);
			}
		}
	}

}
