using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // タップされたスクリーン座標(Input.mousePosition)を元にして、バスケットを移動させる座標を計算する.
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //スクリーン座標をワールド座標に変換
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
            }
        }
    }

    // onTriggerEnter.
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Catch!!");
        if (other.gameObject.tag == "Apple")
        {
            Debug.Log("Apple!!");
        }
        else if (other.gameObject.tag == "Bomb")
        {
            Debug.Log("Bomb!!");
        }
        Destroy(other.gameObject);
    }
}
