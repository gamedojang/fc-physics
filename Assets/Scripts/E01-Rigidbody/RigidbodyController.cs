using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("T");
    }
}
