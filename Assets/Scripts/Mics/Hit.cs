using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    private Died_Script myDied_Script;
    private void Awake()
    {
        myDied_Script = FindAnyObjectByType<Died_Script>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            myDied_Script.Died();
        }
    }
}
