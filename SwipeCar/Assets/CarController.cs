using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
        Debug.Log("height: " + Screen.height);
        Debug.Log("width: " + Screen.width);
    }

    // Update is called once per frame
    void Update()
    {
        // Swipeの長さを求める
        if (Input.GetMouseButtonDown(0))
        {
            // マウスをクリックした座標
            startPosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // マウスを離した座標
            Vector2 endPosition = Input.mousePosition;
            float swipeLength = endPosition.x - startPosition.x;
            // Swipeの長さを初速度に変換する
            // 500.0f: この値を変えると車の初速度が変化する。速度や移動距離を変えたい場合はこの数値を変更してみる。
            speed = swipeLength / 500.0f;
            Debug.Log("GetMouseButtonUp swipeLength: " + swipeLength);
            Debug.Log("GetMouseButtonUp speed: " + speed);
        }
        // Translate: 現在の座標から引数に与えた量だけ移動するメソッド
        // なので、引数には座標を直接示しているわけではない。
        transform.Translate(speed, 0, 0); // 横移動
        speed *= 0.98f; // ゆっくり減速する
        Debug.Log("Update speed: " + speed);
    }
}
