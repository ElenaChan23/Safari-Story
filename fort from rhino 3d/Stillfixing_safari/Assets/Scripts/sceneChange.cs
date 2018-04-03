using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour {

    public float timeToNewScene;

	void goToScene()
    {
        SceneManager.LoadScene("greenLightCars");
    }

    private void Start()
    {
        Invoke("goToScene", timeToNewScene);
    }
    
}
