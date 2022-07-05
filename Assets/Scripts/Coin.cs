using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Coin : MonoBehaviour
{
    [SerializeField] protected ScriptableCoin scriptCoin;
    public static event Action<float> CoinEvent;
    public abstract void Action();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CoinEvent?.Invoke(scriptCoin.addtime);
            Action();
        }
    }
}
