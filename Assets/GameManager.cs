using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Victory;
    public GameObject Defeat;
    public string NextLevel;

    public IEnumerator ProximoNivel()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(NextLevel);
    }
    public void victoria()
    {
        Victory.SetActive(true);
        StartCoroutine(ProximoNivel());
    }

    public IEnumerator derrota()
    {
        Debug.Log("llegaste");
        Defeat.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Lvl 1");
    }

    public void ActivarDerrota()
    {
        StartCoroutine(derrota());
    }


    private void OnEnable()
    {
        LevelExit.LevelComplete += victoria;
        Spikes.PlayerDeath += ActivarDerrota;
        Timer.PlayerDeath += ActivarDerrota;
    }

    private void OnDisable()
    {
        LevelExit.LevelComplete -= victoria;
        Spikes.PlayerDeath -= ActivarDerrota;
        Timer.PlayerDeath -= ActivarDerrota;
    }
}
