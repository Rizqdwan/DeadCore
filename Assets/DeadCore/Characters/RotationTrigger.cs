using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeadCore
{
    public class RotationTrigger : MonoBehaviour
    {
        public Transform characterToRotate;
        public float rotationAngle = 90f;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "RotationCube")
            {
                RotateCharacter();
            }
        }

        private void RotateCharacter()
        {
            if (characterToRotate != null)
            {
                // Rotate the character by the specified angle around the Y-axis
                characterToRotate.Rotate(Vector3.up, rotationAngle);
            }
            else
            {
                Debug.LogWarning("Character to rotate not assigned in the inspector!");
            }
        }
    }
}


