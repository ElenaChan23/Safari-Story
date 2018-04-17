using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VRStandardAssets.Utils
{

    public class FadeIn : MonoBehaviour
    {

        public float fadeLength;
        public bool fadeAudio;
        public VRCameraFade cameraFade;

        // Use this for initialization
        void Start()
        {
            cameraFade.FadeIn(fadeLength, fadeAudio);
        }

    }
}