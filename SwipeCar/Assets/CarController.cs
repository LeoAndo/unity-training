using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            speed = 0.3f;
        }
        // Translate: 現在の座標から引数に与えた量だけ移動するメソッド
        // なので、引数には座標を直接示しているわけではない。
        transform.Translate(speed, 0, 0); // 横移動
        speed *= 0.98f; // ゆっくり減速する
        Debug.Log("speed: " + speed);
    }
}
