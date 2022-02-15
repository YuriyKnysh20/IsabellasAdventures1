using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            Debug.Log("Yes");
        }

        offset = player.transform.position - transform.position;
    }

    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
