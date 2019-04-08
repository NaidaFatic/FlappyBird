using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScroll : MonoBehaviour
{

    private Rigidbody2D rb;

    private BoxCollider2D groundCollider;
    private float horizontalLength;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-2, 0);

        groundCollider = GetComponent<BoxCollider2D>();
        horizontalLength = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
      
        if (transform.position.x < -horizontalLength)
        {
            transform.position = new Vector2(horizontalLength * 1.54f, transform.position.y);

        }
    }
}
