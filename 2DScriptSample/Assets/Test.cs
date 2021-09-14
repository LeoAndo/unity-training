using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine; // Unityを動かすために必要な機能を提供する

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start!");
        Vector2 objPosition = new Vector2(5, 4);
        objPosition.x += 6;
        objPosition.y += 8;
        Debug.Log(objPosition);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update!");
    }


}
