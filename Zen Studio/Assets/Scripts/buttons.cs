using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttons : MonoBehaviour {

	Animator yogi_2;
	public GameObject b1;
	public bool idle;
	public GameObject PauseButton;
	public GameObject ResumeButton;
	public GameObject QuitMainButton;
	public GameObject StartButton;
	public GameObject MoreButton;
	public GameObject CreditsButton;
	public GameObject QuitButton;
	public GameObject BackButton;
	public GameObject Back2Button;
	public GameObject Image;
	public GameObject RawImage;
	public GameObject MoreInfo;
	public GameObject Credit;
	private AudioSource [] audioSource;

	void Start () {
		
		yogi_2 = GetComponent<Animator> ();
		audioSource = GetComponents<AudioSource>();
		// audioSource[0].Play();
		idle = false;

		Button btn = PauseButton.GetComponent<Button>();
		btn.onClick.AddListener(Pause);
		Button btn1 = ResumeButton.GetComponent<Button>();
		btn1.onClick.AddListener(Resume);
		Button btn2 = QuitMainButton.GetComponent<Button>();
		btn2.onClick.AddListener(QuitMain);
		Button btn3 = StartButton.GetComponent<Button>();
		btn3.onClick.AddListener(StartB);
		Button btn4 = MoreButton.GetComponent<Button>();
		btn4.onClick.AddListener(More);
		Button btn5 = BackButton.GetComponent<Button>();
	    btn5.onClick.AddListener(Back);
		Button btn6 = CreditsButton.GetComponent<Button>();
		btn6.onClick.AddListener(Credits);
		Button btn7 = Back2Button.GetComponent<Button>();
		btn7.onClick.AddListener(Back2);

		ResumeButton.SetActive(false);
		QuitMainButton.SetActive(false);
		BackButton.SetActive (false);
		Back2Button.SetActive (false);
		MoreInfo.SetActive (false);
		Credit.SetActive (false);

	}

	void Update () {
		
			if (Input.GetKeyDown (KeyCode.A)) {
				yogi_2.SetBool ("level", false);
				b1.SetActive (false);
				yogi_2.SetBool ("start", false);
			    audioSource[0].Play();

			}

			if (Input.GetKeyDown (KeyCode.B)) {
				yogi_2.SetBool ("level", true);
				b1.SetActive (false);
				yogi_2.SetBool ("start", false);
			    audioSource[0].Play();
			}

			if (idle) {
				b1.SetActive (true);

				yogi_2.SetBool ("start", true);
				yogi_2.SetBool ("level", true);
				yogi_2.SetBool ("idle", true);
			}


	}

	void StartB() {
		
		Image.SetActive (false);
		RawImage.SetActive (false);
		StartButton.SetActive (false);
		MoreButton.SetActive (false);
		CreditsButton.SetActive (false);
		QuitButton.SetActive (false);
	}

	void More() {
		
		MoreInfo.SetActive (true);
		BackButton.SetActive (true);
		StartButton.SetActive (false);
		MoreButton.SetActive (false);
		CreditsButton.SetActive (false);
		QuitButton.SetActive (false);
	}

	void Credits(){

		Credit.SetActive (true);
		Back2Button.SetActive (true);
		StartButton.SetActive (false);
		MoreButton.SetActive (false);
		CreditsButton.SetActive (false);
		QuitButton.SetActive (false);
	}


	void Resume(){
		
		yogi_2.enabled = true;
		ResumeButton.SetActive(false);
		QuitMainButton.SetActive(false);
	}

	void Pause() {

		yogi_2.enabled = false;
		ResumeButton.SetActive(true);
		QuitMainButton.SetActive(true);

	}

	void QuitMain(){
		
		Image.SetActive (true);
		RawImage.SetActive (true);
		StartButton.SetActive (true);
		MoreButton.SetActive (true);
		CreditsButton.SetActive (true);
		QuitButton.SetActive (true);
		Application.LoadLevel (0);

	}

	void Back() {
		
	    MoreInfo.SetActive (false);
		 //Credit.SetActive (false);
		BackButton.SetActive (false);
		StartButton.SetActive (true);
		MoreButton.SetActive (true);
		CreditsButton.SetActive (true);
		QuitButton.SetActive (true);
	}

	void Back2() {
		
		Credit.SetActive (false);
		Back2Button.SetActive (false);
		StartButton.SetActive (true);
		MoreButton.SetActive (true);
		CreditsButton.SetActive (true);
		QuitButton.SetActive (true);
	}

	void Quit() {
		
		Application.Quit ();

}
}
