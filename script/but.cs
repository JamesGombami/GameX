using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class but : MonoBehaviour {

    public GameObject videoPanel;
    private bool isVideoPlaying = false;
    public static VideoPlayer video;


    // Use this for initialization
    void Start()
    {
        video = videoPanel.GetComponent<VideoPlayer>();
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void PlayVideo()
    {
            video.Play();
            isVideoPlaying = true;
    }

    public void StopVideo()
    {
        video.Stop();
        isVideoPlaying = false;
    }


    public void OnButtonReleased()
    {

    }
}