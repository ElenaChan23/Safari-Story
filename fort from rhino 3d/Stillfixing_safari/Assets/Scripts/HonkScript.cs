using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class HonkScript : MonoBehaviour
{
	public AudioClip shortHonk;
	public AudioClip mediumHonk;
	public AudioClip longHonk;
	public AudioClip finalHonk;
	public float fadeOutTime;

	public AudioSource radio;


	IEnumerator Start()
	{
		AudioSource audio = GetComponent<AudioSource>();
		yield return new WaitForSeconds (1.0f);
	
		audio.clip = shortHonk;
		audio.Play();
		yield return new WaitForSeconds (0.3f);
		audio.Play();
		yield return new WaitForSeconds (0.3f);
		audio.Play();
		yield return new WaitForSeconds (0.3f);

		audio.clip = mediumHonk;
		audio.Play ();
		yield return new WaitForSeconds (1.0f);
/*		audio.Play ();
		yield return new WaitForSeconds (1.5f);

		audio.clip = longHonk;
		audio.Play ();
		yield return new WaitForSeconds (3.7f);
/*

		audio.clip = shortHonk;
		audio.Play();
		yield return new WaitForSeconds (0.3f);
		audio.Play();
		yield return new WaitForSeconds (0.3f);
*/

		audio.clip = finalHonk;
		audio.Play ();
		yield return new WaitForSeconds (1.5f);
		StartCoroutine(AudioFadeScript.FadeOut (audio, fadeOutTime));
		radio.GetComponent<AfricaAudio>().PlayAfrica();
	

	}
}