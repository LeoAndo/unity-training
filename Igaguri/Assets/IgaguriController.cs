using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Shoot(new Vector3(0, 200, 2000));
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Shoot.
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    // isKinematic true. onCollisitoinEnter.
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play(); // 衝突したら、エフェクトを再生する.
    }
}
