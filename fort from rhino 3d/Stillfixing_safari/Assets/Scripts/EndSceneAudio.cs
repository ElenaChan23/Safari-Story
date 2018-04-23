using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneAudio : MonoBehaviour {

	public AudioSource AS1;
	public AudioSource AS2;
	public AudioSource AS3;
	public AudioSource AS4;
	private float transitionTime = 2.0f;
	public AudioEchoFilter echo;

	public void FadeAll() {

		//Debug.Log ("HI THERE FRIENDO");
		if (AS1 != null) {
			StartCoroutine(AudioFadeScript.FadeOut (AS1, transitionTime));
		}
		if (AS2 != null) {
			StartCoroutine(AudioFadeScript.FadeOut (AS2, transitionTime));
		}
		if (AS3 != null) {
			StartCoroutine(AudioFadeScript.FadeOut (AS3, transitionTime));
		}
		if (AS4 != null) {
			StartCoroutine(AudioFadeScript.FadeOut (AS4, transitionTime));
		}
		if (echo != null) {
			echo.enabled = true;
		}
	}

}
