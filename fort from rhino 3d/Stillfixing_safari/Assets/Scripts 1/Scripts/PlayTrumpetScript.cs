using System.Collections;
using UnityEngine;

public static class PlayTrumpetScript{

	public static IEnumerator PlayTrumpet(AudioClip trumpet, AudioClip horn, AudioSource elephantAudio)
	{
		yield return new WaitForSeconds (23.0f);
		elephantAudio.clip = trumpet;
		elephantAudio.Play();
		yield return new WaitForSeconds (13.0f);
		elephantAudio.Play();

		elephantAudio.clip = horn;
		elephantAudio.spatialBlend = 0.5f;
		yield return new WaitForSeconds (8.4f);
		elephantAudio.Play();


	}
}
