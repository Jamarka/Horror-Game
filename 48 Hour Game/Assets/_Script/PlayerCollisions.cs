using UnityEngine;
using System.Collections;

public class PlayerCollisions : MonoBehaviour {

	//public LevelManager levelManager;
	
	void OnTriggerEnter(Collider target)
	{
		if (target.tag == "Player"){
			Application.LoadLevel ("LoseScreen");
		}
		this.GetComponent<MeshCollider>().enabled = false;
	}
}
