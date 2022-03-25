using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float minY, maxY;
    public float speed = 10.0f;
    private Rigidbody2D rBody;
    float vert;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        vert = Random.value < 0.5f ? -1.0f : 1.0f;
        Vector2 newVelocity = new Vector2(0.0f, 1.0f);
        GetComponent<Rigidbody2D>().velocity = newVelocity * speed;
    }
    void Update()
    {

       // float newY;
        //newY = Mathf.Clamp(rBody.position.y, minY, maxY);

       // rBody.position = new Vector2(this.transform.position.x, newY);

        //float newY;
        //newY = Mathf.Clamp(rBody.position.y, minY, maxY);

        // rBody.position = new Vector2 (rBody.position.x, newY);
    }

}
