using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******* MI class SunPatrol
 * Simple class to initiate random movement for the sun enemies. On collision 
 with the game boundaries, the sun returns back in the same direction.
 */

public class SunPatrol : MonoBehaviour
{
    private Rigidbody2D rb2d;
    void GoSun()
    {
        //initiating new forces in different conditions 

        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(50, 50));
        }
        else
        {
            rb2d.AddForce(new Vector2(-50, -50));
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.zero;
        GoSun();


    }

    // if the sun collides with any walls of the game, make the force negative.
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        if (hitInfo.name == "wall1" || hitInfo.name == "wall2" || hitInfo.name == "wall3" || hitInfo.name == "wall4" || hitInfo.name == "Player")
        {
            Vector2 vel;
            vel.x = -rb2d.velocity.x;
            vel.y = -rb2d.velocity.y;
            rb2d.velocity = vel;
        }
        
        /*
        // Let the sun switch directions upon collision with walls

        if (hitInfo.name == "wall1" || hitInfo.name == "wall2" || hitInfo.name == "wall3" || hitInfo.name == "wall4" || hitInfo.name == "Player")
        {
            int num = Random.Range(0, 3);
            if (num == 0)
            {
                Vector2 vel;
                vel.x = -rb2d.velocity.x;
                vel.y = -rb2d.velocity.y;
                rb2d.velocity = vel;
            }
            else if (num == 1)
            {
                Vector2 vel;
                vel.y = -rb2d.velocity.y;
                rb2d.velocity = vel;
            }
            else
            {
                Vector2 vel;
                vel.x = -rb2d.velocity.x;
                rb2d.velocity = vel;
            }
        }
        */
    }
}

