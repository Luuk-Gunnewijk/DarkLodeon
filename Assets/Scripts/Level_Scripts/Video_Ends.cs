using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Video_Ends : MonoBehaviour
{
    public VideoPlayer myVideoPlayer;

    void Update()
    {
        if (!myVideoPlayer.isPlaying)
        {
            myVideoPlayer.Stop();
            SceneManager.LoadScene("Main_Menu");
        }
    }
}
