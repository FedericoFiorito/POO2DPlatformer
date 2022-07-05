using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Coin", menuName = "Coin")]
public class ScriptableCoin : ScriptableObject
{
    [SerializeField] private float AddTime;
    public float addtime { get { return AddTime; } }
}
