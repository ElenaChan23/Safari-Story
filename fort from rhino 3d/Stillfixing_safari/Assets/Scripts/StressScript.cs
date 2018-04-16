using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class StressScript : MonoBehaviour
{
	public AudioSource jackHammer;
	public AudioSource traffic;
	public float fadeInTime;
	public float fadeOutTime;


	void Start()
	{
		StartCoroutine(AudioFadeScript.FadeIn (jackHammer, fadeInTime, 1.0f));
		StartCoroutine(AudioFadeScript.FadeIn (traffic, fadeInTime, 1.0f));
	}
}