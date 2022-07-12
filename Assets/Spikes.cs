using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spikes : MonoBehaviour
{
    public static event Action PlayerDeath;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerDeath?.Invoke();
        }
    }
}
