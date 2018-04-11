using UnityEngine;
using System.Collections;

public static class AudioFadeScript
{
	public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime, float finalVolume = 0.0f)
	{

		float startVolume = audioSource.volume;

		while (audioSource.volume > finalVolume)
		{
			audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

			yield return null;
		}

		if (audioSource.volume <= 0) {
			audioSource.Stop ();
			audioSource.volume = startVolume;
		}
	}

	public static IEnumerator FadeIn(AudioSource audioSource, float FadeTime, float finalVolume)
	{
		float startVolume = finalVolume;

		audioSource.volume = 0;

		audioSource.Play ();

		while (audioSource.volume < finalVolume)
		{
			audioSource.volume += startVolume * Time.deltaTime / FadeTime;

			yield return null;
		}

		audioSource.volume = 1f;
	}
}