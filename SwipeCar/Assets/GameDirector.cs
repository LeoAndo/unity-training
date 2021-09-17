using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // <Text>にアクセスするために必要.

// 監視オブジェクト
// FlagとCarの距離を計算し、Textに表示する.
public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        // オブジェクトを取得する
        car = GameObject.Find("car"); // オブジェクト名を引数に取る
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        // GameObjectの座標は object名.transform.position.x で取得可能.
        float length = flag.transform.position.x - car.transform.position.x;
        if (length >= 0)
        {
            // F2: 小数点以下第2位まで表示
            distance.GetComponent<Text>().text = "ゴールまで" + length.ToString("F2") + "m";
        }
        else
        {
            distance.GetComponent<Text>().text = "ゲームオーバー";
        }
    }
}
