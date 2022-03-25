using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring2 : MonoBehaviour
{
    public GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            gameManager.Player2Scores();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
