using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherPlayerCOntroller : MonoBehaviour
{
    public float speed;
    public float minY, maxY;

    private Rigidbody2D rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float vert;
        //float direction = 0.0f;
        Vector2 newVelocity = new Vector2(rBody.velocity.x, rBody.velocity.y);
        vert = Input.GetAxis("Horizontal");
        newVelocity = new Vector2(0.0f, -vert);

        GetComponent<Rigidbody2D>().velocity = newVelocity * speed;

        //float newY;
        //newY = Mathf.Clamp(rBody.position.y, minY, maxY);

        // rBody.position = new Vector2 (rBody.position.x, newY);

    }
}
