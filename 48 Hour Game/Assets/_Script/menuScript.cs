using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuScript : MonoBehaviour {

	public Canvas quitMenu;
	//public Button startText;
	//public Button exitText;
	public Canvas buttons;

	// Use this for initialization
	void Start () {
	
		quitMenu = quitMenu.GetComponent<Canvas> ();
		//startText = startText.GetComponent<Button> ();
		//exitText = exitText.GetComponent<Button> ();
		buttons = buttons.GetComponent<Canvas> ();
		quitMenu.enabled = false;
	}
	
	
	public void ExitPress(){
		quitMenu.enabled = true;
		buttons.enabled = false;
		//startText.enabled = false;
		//exitText.enabled = false;
	}
	
	public void NoPress() {
		quitMenu.enabled = false;
		buttons.enabled = true;
		//startText.enabled = true;
		//exitText.enabled = true;
	}
	
	public void StartLevel() {
		Application.LoadLevel (1);
	}
	
	public void ExitGame() {
		Application.Quit();
	}

}
