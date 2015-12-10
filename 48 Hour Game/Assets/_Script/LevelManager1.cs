using UnityEngine;
using System.Collections;

public class LevelManager1 : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		bool spikeWall = false;
		if (this.tag == "SpikedWall"){
			spikeWall = true; 
		}
		print (spikeWall);
		Application.LoadLevel(0);
		
	}
}
