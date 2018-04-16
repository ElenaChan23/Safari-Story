using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class RadioScript : MonoBehaviour
{
	public AudioClip songClip;
	public AudioClip radioClip;
	public AudioClip africa;
	public float fadeInTime;
	public float musicTime;
	public float fadeOutTime;


	IEnumerator Start()
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.clip = songClip;

		StartCoroutine(AudioFadeScript.FadeIn (audio, fadeInTime, 1.0f));
		yield return new WaitForSeconds(fadeInTime);
		yield return new WaitForSeconds(musicTime);
		StartCoroutine(AudioFadeScript.FadeOut (audio, fadeOutTime));
		yield return new WaitForSeconds(fadeOutTime);
		audio.clip = radioClip;
		audio.volume = 0.6f;
		audio.Play();
		yield return new WaitForSeconds (23.6f);
		audio.Stop ();
		yield return new WaitForSeconds (0.8f);
		audio.clip = africa;
		StartCoroutine(AudioFadeScript.FadeIn (audio, fadeInTime, 0.5f));
	}
}