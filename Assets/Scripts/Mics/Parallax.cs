using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float lenght, startpos;
    [SerializeField] private GameObject cam;
    [SerializeField] private float parallaxEffect;

    void Start()
    {
        startpos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void FixedUpdate()
    {
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startpos + dist, transform.position.y,transform.position.z);
    }
}
