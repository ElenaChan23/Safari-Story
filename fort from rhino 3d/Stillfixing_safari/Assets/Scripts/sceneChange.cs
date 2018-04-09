using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour {

    public float timeToNewScene;
    public string sceneToLoad;

	void goToScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void startTransitionTimer()
    {
        Invoke("goToScene", timeToNewScene);
    }
    
}
