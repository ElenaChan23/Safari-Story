using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRStandardAssets.Utils;


public class DoorOpen : MonoBehaviour {

    public TimelineController timelines;
    public sceneChange sceneChanger;

	public AudioSource frontfeet;
	public AudioSource backfeet;
	public AudioClip trumpet;
	public AudioClip horn;

	public AudioSource elephantAudio;

    [SerializeField] private SelectionRadial m_SelectionRadial;         // This controls when the selection is complete.
    [SerializeField] private VRInteractiveItem m_InteractiveItem;       // The interactive item for where the user should click to load the level.


    private bool m_GazeOver;                                            // Whether the user is looking at the VRInteractiveItem currently.


    private void OnEnable()
    {
        Console.Write("Enabled");

        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
        m_SelectionRadial.OnSelectionComplete += HandleSelectionComplete;
    }


    private void OnDisable()
    {
        m_InteractiveItem.OnOver -= HandleOver;
        m_InteractiveItem.OnOut -= HandleOut;
        m_SelectionRadial.OnSelectionComplete -= HandleSelectionComplete;
    }


    private void HandleOver()
    {
        // When the user looks at the rendering of the scene, show the radial.
        Console.Write("looked at");
        m_SelectionRadial.Show();

        m_GazeOver = true;
    }


    private void HandleOut()
    {
        // When the user looks away from the rendering of the scene, hide the radial.
        m_SelectionRadial.Hide();

        m_GazeOver = false;
    }


    private void HandleSelectionComplete()
    {
        // If the user is looking at the rendering of the scene when the radial's selection finishes, activate the button.
		if (m_GazeOver) {
            sceneChanger.startTransitionTimer();
			timelines.Play ();

			backfeet.time = 1.0f;
			frontfeet.Play ();
			backfeet.Play ();
			StartCoroutine(PlayTrumpetScript.PlayTrumpet (trumpet, horn, elephantAudio));

			Debug.Log("now");

		}
    }



}
