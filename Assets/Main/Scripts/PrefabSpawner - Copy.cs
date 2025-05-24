using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{

    public GameObject head;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0,0,100), 5f * Time.fixedDeltaTime);
    }
}