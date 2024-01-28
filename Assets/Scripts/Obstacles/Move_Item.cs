using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Item : MonoBehaviour
{
    [SerializeField] private int destroyTime;
    [SerializeField] private float moveSpeed = 1;

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    void Update()
    {
        transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
    }
}
