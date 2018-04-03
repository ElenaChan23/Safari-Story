using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRStandardAssets.Utils
{
    public class FadeOut : MonoBehaviour {

        public float timeToOut;
        public float fadeLength;
        public bool fadeAudio;
        public VRCameraFade cameraFade;

        void fadeOut()
        {
            cameraFade.FadeOut(fadeLength, fadeAudio);
        }

        private void Start()
        {
            Invoke("fadeOut", timeToOut);
        }
    }
}
