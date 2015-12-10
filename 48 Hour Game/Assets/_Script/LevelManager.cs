using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnTriggerEnter(Collider col)
	{
		bool spikeWall = false;
		if (this.tag == "SpikedWall"){
			spikeWall = true; 
		}
		
		Application.LoadLevel(0);
		
	}
}
