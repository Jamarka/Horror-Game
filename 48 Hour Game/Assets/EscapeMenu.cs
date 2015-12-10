using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EscapeMenu : MonoBehaviour {

	public Canvas escapeMenu;
	public Button cont;
	
	//public PlayerMovement mouseLook;

	// Use this for initialization
	void Start () {
		escapeMenu = escapeMenu.GetComponent<Canvas> ();
		cont = cont.GetComponent<Button> ();
		escapeMenu.enabled = false;
		
	}
	
	void Update() {
			if (Input.GetKeyDown(KeyCode.Escape)){
				escapeMenu.enabled = true;
			//EscPress ();
		}
	}
	
	
	public void Continue() {
		escapeMenu.enabled = false;
	}
	//public void EscPress() {
		//Time.timeScale = 0f;
		//GetComponent("MouseLook").enabled = !GetComponent("MouseLook").enabled;
		//escapeMenu.enabled = true;
	
		
	
}
