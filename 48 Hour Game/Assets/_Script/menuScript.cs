using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Canvas buttons;

	// Use this for initialization
	void Start () {
	
		quitMenu = quitMenu.GetComponent<Canvas> ();
		buttons = buttons.GetComponent<Canvas> ();
		quitMenu.enabled = false;
	}
	
	
	public void ExitPress(){
		quitMenu.enabled = true;
		buttons.enabled = false;
	}
	
	public void NoPress() {
		quitMenu.enabled = false;
		buttons.enabled = true;
	}
	
	public void StartLevel() {
		Application.LoadLevel (1);
	}
	
	public void ExitGame() {
		Application.Quit();
	}

}
