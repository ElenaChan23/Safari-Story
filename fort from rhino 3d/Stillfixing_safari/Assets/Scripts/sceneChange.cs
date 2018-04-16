using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour {

    public float timeToNewScene;
    public string sceneToLoad;

    private void Start()
    {
        startTransitionTimer();
    }

    void goToScene()
    {
        StartCoroutine(LoadAsyncScene());
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

}
