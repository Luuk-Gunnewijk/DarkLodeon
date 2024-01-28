using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnEnter : MonoBehaviour
{
    private AudioSource myAudioScource;
    private void Start()
    {
        myAudioScource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        myAudioScource.Play();
    }
}
