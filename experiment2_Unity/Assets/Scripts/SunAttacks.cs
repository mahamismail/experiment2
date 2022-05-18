using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******* MI class SunAttacks
 *  Simple class for the sun attacking the player when it comes within range. The player loses health.
 */

public class SunAttacks : MonoBehaviour
{
        private PlayerController player;
        public GameObject sunEffect;
        public int healthLoss;

        private void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }

        private void OnTriggerEnter2D(Collider2D hitInfo)
        {
        if (hitInfo.name == "Player")
        {
            // add animation effect when the sun attacks
            Instantiate(sunEffect, player.transform.position, Quaternion.identity);
            // player loses health
            player.health -= healthLoss;
        }
        }
}
