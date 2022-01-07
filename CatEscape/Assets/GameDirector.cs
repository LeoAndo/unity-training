using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UIオブジェクトをスクリプトから操作する場合に必要

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // decreaseHp
    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
