using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverCoin : Coin
{
    public override void Action()
    {
        Destroy(this.gameObject);
    }


}
