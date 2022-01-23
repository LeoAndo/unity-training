using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    // 生成するアイテムの総数
    public const int Total = 10;
    // アイテムのPrefab
    [SerializeField]
    private GameObject _itemPrefab;
    // Start is called before the first frame update
    void Start()
    {
        CreateItems();
    }

    // Update is called once per frame
    void Update()
    {

    }
    // アイテムを生成
    private void CreateItems()
    {
        for (int i = 0; i < Total; i++)
        {
            GameObject item = Instantiate(_itemPrefab);
            item.transform.position = GetRandomItemPosition();
        }
    }
    // ランダムにアイテムを配置する座標を返す
    private Vector3 GetRandomItemPosition()
    {
        // 1f～3.5fの間でランダムにX座標を決定
        var x = UnityEngine.Random.Range(1f, 3.5f);
        // 1/2の確率で反転
        if (UnityEngine.Random.Range(0, 2) % 2 == 0)
        {
            x *= -1f;
        }

        // 1f～3.5fの間でランダムにZ座標を決定
        var z = UnityEngine.Random.Range(1f, 3.5f);
        // 1/2の確率で反転
        if (UnityEngine.Random.Range(0, 2) % 2 == 0)
        {
            z *= -1f;
        }

        return new Vector3(x, 0f, z);
    }
}
