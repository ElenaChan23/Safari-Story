using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NatureSoundsScript : MonoBehaviour {

	public float fadeInTime;

	public AudioSource grass;
	public AudioSource bird1;
	public AudioSource bird2;
	public AudioSource bird3;
	public AudioSource music;



	// Use this for initialization
	void Start () {
		StartCoroutine(AudioFadeScript.FadeIn (grass, fadeInTime, 1.0f));
		StartCoroutine(AudioFadeScript.FadeIn (bird1, fadeInTime, 1.0f));
		StartCoroutine(AudioFadeScript.FadeIn (bird2, fadeInTime, 1.0f));
		StartCoroutine(AudioFadeScript.FadeIn (bird3, fadeInTime, 1.0f));
		StartCoroutine(AudioFadeScript.FadeIn (music, fadeInTime, 0.1f));
	}

}
