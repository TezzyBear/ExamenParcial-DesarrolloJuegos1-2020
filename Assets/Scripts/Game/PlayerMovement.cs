using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector]
    private Rigidbody2D body;
    private SpriteRenderer spr;
    float xHalfWidth;
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        xHalfWidth = Camera.main.orthographicSize;
        spr = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) {
            body.velocity = new Vector2(-2, 0);
        } else if (Input.GetKey(KeyCode.D)) {
            body.velocity = new Vector2(2, 0);
        } else {
            body.velocity = new Vector2();
        }
        keepInBounds();
        
    }

    void keepInBounds() {
        if (transform.position.x > xHalfWidth - spr.size.x/2) {
            transform.position = new Vector3(xHalfWidth - spr.size.x/2, transform.position.y, 0f);
        } else if (transform.position.x < -xHalfWidth + spr.size.x/2) {
            transform.position = new Vector3(-xHalfWidth + spr.size.x/2, transform.position.y, 0f);
        }
    }
}

