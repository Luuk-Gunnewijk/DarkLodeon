using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Open_Close_UI : MonoBehaviour
{
    private bool canPressE;

    private AudioSource myAudioSource;

    [SerializeField] private Canvas myCanvas;
    [SerializeField] Animator myAnimator;

    private void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        PressingE();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        myCanvas.enabled = true;
        canPressE = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        myCanvas.enabled = false;
        canPressE = false;
    }

    private void PressingE()
    {
        if (Input.GetKeyDown(KeyCode.E) && canPressE == true)
        {
            myAnimator.SetBool("CanSnuif", true);
            myAudioSource.Play();
            myCanvas.enabled = false;
            Destroy(gameObject, 2f);
        }
        else
        {
            myAnimator.SetBool("CanSnuif", false);
        }
    }
}
