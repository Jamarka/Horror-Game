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
	
	void OnTriggerEnter(Collider target)
	{
		if (target.tag == "Player"){
			print (target.tag);

			Application.LoadLevel(0);
		}
		
		
		
	}
}
