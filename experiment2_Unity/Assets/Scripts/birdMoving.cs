using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdMoving : MonoBehaviour
{

    private Rigidbody2D rb2d;
    void GoBird()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(-50, 50));
        }
        else
        {
            rb2d.AddForce(new Vector2(50,-50));
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.zero;
        GoBird();
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        if (hitInfo.name == "wall1" || hitInfo.name == "wall2" || hitInfo.name == "wall3" || hitInfo.name == "wall4" || hitInfo.name == "Player")
        {
            Vector2 vel;
            vel.x = -rb2d.velocity.x;
            vel.y = -rb2d.velocity.y;
            rb2d.velocity = vel;
        }

    }
}

