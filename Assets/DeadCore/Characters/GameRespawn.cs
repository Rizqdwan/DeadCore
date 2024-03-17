using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeadCore
{
    public class GameRespawn : MonoBehaviour
    {
        public float threshold;
        public float respawnDelay = 1.0f; // Adjust this value as needed

        private float timeSinceFall;

        private void Update()
        {
            if (transform.position.y <= threshold)
            {
                timeSinceFall += Time.deltaTime;

                if (timeSinceFall >= respawnDelay)
                {
                    Respawn();
                }
            }
            else
            {
                // Reset the timer when the character is not falling
                timeSinceFall = 0f;
            }
        }

        private void Respawn()
        {
            // Your respawn logic here
            //transform.position = new Vector3(-0.24f, 33.8f, -4.4f);
            transform.position = new Vector3(- 0.24f, 33.457f, -4.4f);
            // Additional respawn actions if needed

            // Reset the timer after respawn to avoid immediate respawning
            timeSinceFall = 0f;
        }
    }
}


