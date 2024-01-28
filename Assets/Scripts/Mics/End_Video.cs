using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class End_Video : MonoBehaviour
{
    public VideoPlayer myVideoPlayer;

    void Update()
    {
        if (!myVideoPlayer.isPlaying)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
