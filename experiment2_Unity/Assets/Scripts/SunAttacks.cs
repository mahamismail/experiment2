using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Instantiate(sunEffect, player.transform.position, Quaternion.identity);
            player.health -= healthLoss;
        }
        }
}
