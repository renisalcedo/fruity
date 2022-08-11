using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movements = new Vector2 (moveHorizontal, moveVertical);

        rb.AddForce (movements * speed);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "fruit") {
            other.gameObject.transform.position = new Vector3(0,0,0);
        }
    }
}
