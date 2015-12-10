using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Canvas buttons;
	public AudioSource audio;

	// Use this for initialization
	void Start () {
	
		quitMenu = quitMenu.GetComponent<Canvas> ();
		buttons = buttons.GetComponent<Canvas> ();
		quitMenu.enabled = false;
		audio =  audio.GetComponent<AudioSource> ();
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
		audio.Play ();
		StartCoroutine(Example());
	}
	
	public void ExitGame() {
		Application.Quit();
	}

	
	IEnumerator Example() {
		yield return new WaitForSeconds(audio.clip.length);
		Application.LoadLevel (1);
	}

}
