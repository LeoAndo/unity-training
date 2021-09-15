using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// クリックすると一定の速さで回転するスクリプト
public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 回転速度

    // Start is called before the first frame update
    // スクリプト起動直後に一度だけ呼ばれるメソッド
    void Start()
    {

    }

    // Update is called once per frame
    // 1フレームごとに繰り返し呼ばれるメソッド.
    void Update()
    {
        // マウスが押されたら回転速度を設定
        // GetMouseButtonDownメソッドはマウスがクリックされた瞬間に一度だけ「true」を返す
        if (Input.GetMouseButtonDown(0)) // 引数 0: 左クリック, 1: 右クリック, 2: 中ボタンクリック
        {
            this.rotSpeed = 10;
        }

        // 回転速度分、ルーレットを回転する.
        // 引数に回転量を指定する。プラスの場合は反時計回り、マイナスの場合は時計回りに回転する
        transform.Rotate(0, 0, this.rotSpeed);
    }
}
