using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRStandardAssets.Utils
{
    public class FadeOut : MonoBehaviour {

        public float timeToGreen;
        public float fadeLengthGreen;
        public float fadeLengthBlack;
        public bool fadeAudioAtEnd;
        public VRCameraFade cameraFade1;

        void fadeToGreen()
        {
            cameraFade1.OnFadeComplete += fadeToBlack;
            cameraFade1.FadeOut(fadeLengthGreen, false);
        }

        private void Start()
        {
            
            Invoke("fadeToGreen", timeToGreen);
            
        }

        void fadeToBlack()
        {

        }
    }
}
