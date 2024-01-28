using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SlabAnim : MonoBehaviour
{
    private Animator myAnimator;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        SlabAnimStart();
    }

    private void SlabAnimStart()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myAnimator.SetBool("IsSlabing", true);
            StartCoroutine(SlabRoutine());
        }
    }

    IEnumerator SlabRoutine()
    {
        yield return new WaitForSeconds(.5f);
        myAnimator.SetBool("IsSlabing", false);
    }
}
