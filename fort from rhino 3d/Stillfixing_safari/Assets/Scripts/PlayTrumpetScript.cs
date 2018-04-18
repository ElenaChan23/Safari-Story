using System.Collections;
using UnityEngine;

public class PlayTrumpetScript : MonoBehaviour {

	public AudioClip trumpet;
	public AudioClip horn;
	public AudioSource elephantAudio;
	public AudioSource frontfeet;
	public AudioSource backfeet;

	public IEnumerator Start()
	{
		yield return new WaitForSeconds (12.0f);
		frontfeet.Play ();
		yield return new WaitForSeconds (1.0f);
		backfeet.Play ();

		yield return new WaitForSeconds (9.0f);
		elephantAudio.clip = trumpet;
		elephantAudio.Play();
		yield return new WaitForSeconds (13.0f);
		elephantAudio.clip = trumpet;
		elephantAudio.time = 0;
		elephantAudio.Play();


		elephantAudio.spatialBlend = 0.5f;
		yield return new WaitForSeconds (8.0f);
		elephantAudio.Play();
		elephantAudio.clip = horn;
		yield return new WaitForSeconds (6.0f);
		elephantAudio.time = 0;
		elephantAudio.Play();

	}
}
