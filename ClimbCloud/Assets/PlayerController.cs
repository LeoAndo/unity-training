using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce);
        }

        // move left/right
        int key = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }

        // speed
        float speedx = Mathf.Abs(rb.velocity.x);

        // speed limit
        if (speedx < maxWalkSpeed)
        {
            rb.AddForce(Vector2.right * key * walkForce);
        }

        // Invert according to the direction of movement.
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
        // Change the animation speed according to the speed of the player.
        anim.speed = speedx / 2.0f;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("GOAL!");
        SceneManager.LoadScene("ClearScene");
    }
}
