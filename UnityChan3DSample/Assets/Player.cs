using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // ユニティちゃんの走る速さ
    private const float Speed = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // キーボード入力を進行方向のベクトルに変換して返す
        Vector3 direction = InputToDirection();

        // 進行方向のベクトルの大きさ
        float magnitude = direction.magnitude;

        // 進行方向のベクトルが移動量を持っているかどうか
        if (Mathf.Approximately(magnitude, 0f) == false)
        {
            UpdatePosition(direction);
        }
    }

    // キーボード入力を進行方向のベクトルに変換して返す
    private Vector3 InputToDirection()
    {
        Vector3 direction = new Vector3(0f, 0f, 0f);

        // 「右矢印」を入力
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction.x += 1f;
        }

        // 「左矢印」を入力
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction.x -= 1f;
        }

        // 「上矢印」を入力
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction.z += 1f;
        }

        // 「下矢印を入力」
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction.z -= 1f;
        }

        return direction.normalized;
    }

    // 位置を更新
    private void UpdatePosition(Vector3 direction)
    {
        Vector3 dest = transform.position + direction * Speed * Time.deltaTime;
        dest.x = Mathf.Clamp(dest.x, -4.7f, 4.7f);
        dest.z = Mathf.Clamp(dest.z, -4.7f, 4.7f);
        transform.position = dest;
    }
}
