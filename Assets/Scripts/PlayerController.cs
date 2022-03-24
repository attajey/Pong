using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
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

        vert = Input.GetAxis("Vertical");

        Vector2 newVelocity = new Vector2(0.0f, vert);
        GetComponent<Rigidbody2D>().velocity = newVelocity * speed;

        //float newY;
        //newY = Mathf.Clamp(rBody.position.y, minY, maxY);

       // rBody.position = new Vector2 (rBody.position.x, newY);

    }
}
