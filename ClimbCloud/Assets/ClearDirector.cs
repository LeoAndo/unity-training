using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // mouse down.
        if (Input.GetMouseButtonDown(0))
        {
            // change scene.
            SceneManager.LoadScene("GameScene");
        }
    }
}
