using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriGenerator : MonoBehaviour
{
    public GameObject igaguriPrefab;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject igaguri = Instantiate(igaguriPrefab);
            // 決まった位置に いがぐり を飛ばす
            // igaguri.GetComponent<IgaguriController>().Shoot(new Vector3(0, 200, 2000));
            // タップした場所に いがぐり を飛ばす
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            igaguri.GetComponent<IgaguriController>().Shoot(worldDir.normalized * 2000);
        }
    }
}
