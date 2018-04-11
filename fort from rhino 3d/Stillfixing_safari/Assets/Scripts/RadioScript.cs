using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class RadioScript : MonoBehaviour
{
	public AudioClip songClip;
	public AudioClip radioClip;
	public AudioClip africa;
	public float startTime = 0;
	public float fadeInTime;
	public float musicTime;
	public float fadeOutTime;

	public AudioSource jackhammer;
	public AudioSource traffic;




	IEnumerator Start()
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.clip = songClip;
		audio.time = startTime;

		StartCoroutine(AudioFadeScript.FadeIn (audio, fadeInTime, 1.0f));
		yield return new WaitForSeconds(fadeInTime);
		yield return new WaitForSeconds(musicTime);
		StartCoroutine(AudioFadeScript.FadeOut (audio, fadeOutTime));
		StartCoroutine(AudioFadeScript.FadeOut (traffic, fadeOutTime, 0.5f));
		StartCoroutine(AudioFadeScript.FadeOut (jackhammer, fadeOutTime, 0.5f));
		yield return new WaitForSeconds(fadeOutTime);
		audio.clip = radioClip;
		audio.time = 0;
		audio.volume = 0.6f;
		audio.Play();
		yield return new WaitForSeconds (23.6f);
		audio.Stop ();
		yield return new WaitForSeconds (0.8f);
		audio.clip = africa;
		StartCoroutine(AudioFadeScript.FadeIn (audio, fadeInTime, 0.5f));
	}
}