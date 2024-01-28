using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slab : MonoBehaviour
{
    private AudioSource myAudioSource;

    [SerializeField] GameObject hand;
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        hand.SetActive(false);
    }

    void Update()
    {
        Bitch_Slab();
    }

    private void Bitch_Slab()
    {
        if(Input.GetMouseButton(0)) 
        {
            myAudioSource.Play();
            hand.SetActive(true);
            StartCoroutine(SlabRoutine());
        }
    }

    IEnumerator SlabRoutine()
    {
        yield return new WaitForSeconds(1);
        hand.SetActive(false);
    }
}
