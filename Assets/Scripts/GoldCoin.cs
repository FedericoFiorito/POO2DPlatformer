using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCoin : Coin
{
    public override void Action()
    {
        Destroy(this.gameObject);
    }


}
