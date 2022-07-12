using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LevelExit : MonoBehaviour
{
    public static event Action LevelComplete;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            LevelComplete?.Invoke();
        }
    }
}
