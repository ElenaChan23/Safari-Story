using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace VRStandardAssets.Utils
{
    public class sceneChange : MonoBehaviour
    {

        public float timeToNewScene;
        public string sceneToLoad;

        public float fadeLength;
        public bool fadeAudioAtEnd;
        public VRCameraFade vrCamera;
        public bool echoFade;
        public GameObject radio;

        private void Start()
        {
            startTransitionTimer();
        }

        void goToScene()
        {
            if (echoFade)
            {
                radio.GetComponent<EndSceneAudio>().FadeAll();
            }
            StartCoroutine(LoadAsyncScene());
            Fade(fadeLength, fadeAudioAtEnd);
 
        }

        public void startTransitionTimer()
        {
            Invoke("goToScene", timeToNewScene);
        }

        IEnumerator LoadAsyncScene()
        {
            // The Application loads the Scene in the background as the current Scene runs.
            // This is particularly good for creating loading screens.
            // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
            // a sceneBuildIndex of 1 as shown in Build Settings.

            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoad);

            // Wait until the asynchronous scene fully loads
            while (!asyncLoad.isDone)
            {
                yield return null;
            }
        }

        public void Fade(float length, bool fadeAudio)
        {
            vrCamera.FadeOut(length, fadeAudio);
        }

    }
}
