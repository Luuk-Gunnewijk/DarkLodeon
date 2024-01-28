using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Junkie : MonoBehaviour
{
    private Animator myAnimator;

    [SerializeField] float moveSpeed;
    [SerializeField] float distance;

    [SerializeField] private GameObject myPlayer;

    private void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        Vector3 dir = myPlayer.transform.position - transform.position;
        if(Physics2D.Raycast(transform.position, dir, distance))
        {
            myAnimator.SetBool("IsWalking", true);
            transform.position += new Vector3(-moveSpeed,0,0) * Time.deltaTime;
        }

        Debug.DrawRay(transform.position, dir, Color.red, 1);
    }
}
