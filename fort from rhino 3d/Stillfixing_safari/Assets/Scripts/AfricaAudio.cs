using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfricaAudio : MonoBehaviour {


	bool AudioBegin = false; 
	AudioSource radio;
	public float fadeOutTime;


	void Awake()
	{
		radio = GetComponent<AudioSource>();
		if (!AudioBegin) {
			//radio.Play ();
			DontDestroyOnLoad (this.gameObject);
			AudioBegin = true;
		}
	}

	void Update () {
		if(Application.loadedLevelName == "Intro")
		{
			StartCoroutine(AudioFadeScript.FadeOut (radio, fadeOutTime));
			AudioBegin = false;
			EndThis ();
		}
	}

	IEnumerator EndThis ()
	{
		yield return new WaitForSeconds (fadeOutTime);
		Destroy(this.gameObject);
	}

	public void PlayAfrica() {
		radio.time = 74.4f;
		StartCoroutine (AudioFadeScript.FadeIn (radio, fadeOutTime, 0.4f));
	}

}
