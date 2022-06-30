using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TotalTime;
    int minutes, seconds;
    public Text TimeText;

    private void Start()
    {
        StartCoroutine(StartTime(true));
    }


    public IEnumerator StartTime(bool Start)
    {
        while (Start == true)
        {
            TotalTime -= Time.deltaTime;
            minutes = (int)(TotalTime / 60f);
            seconds = (int)(TotalTime - minutes * 60f);
            TimeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

            if (TotalTime <= 0)
            {
                Debug.Log("perdiste");
                Start = false;
            }
            yield return null;
        }
    }

    void AddTime(float time)
    {
        TotalTime += time;
    }

    private void OnEnable()
    {
        Coin.CoinEvent += AddTime;
    }

    private void OnDisable()
    {
        Coin.CoinEvent -= AddTime;
    }
}
