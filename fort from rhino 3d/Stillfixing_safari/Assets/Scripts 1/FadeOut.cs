using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRStandardAssets.Utils
{
    public class FadeOut : MonoBehaviour {

        public float timeToOut;
        public float fadeLength;
        public bool fadeAudioAtEnd;
        public VRCameraFade cameraFade1;

        void fadeToGreen()
        {
            cameraFade1.FadeOut(fadeLength, false);
        }

        private void Start()
        {
            
            Invoke("fadeToGreen", timeToOut);
            
        }

    }
}
