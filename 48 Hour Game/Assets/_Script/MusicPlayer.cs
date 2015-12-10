using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	public static MusicPlayer instance = null;

	void Awake() {
		print ("hello world");
		if (instance != null) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
			print (instance);
		}
	}

}
