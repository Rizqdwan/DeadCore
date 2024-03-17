using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeadCore
{
    public class doorController : MonoBehaviour
    {
        [SerializeField] private Animator myDoor = null;

        [SerializeField] private bool openTrigger = false;

        [SerializeField] private bool closeTrigger = true;

        [SerializeField] private string doorOpen = "doorOpen";

        [SerializeField] private string doorClose = "doorClose";

        [SerializeField] public Transform pintuCollider;

        [SerializeField] private AudioSource openDoorSoundEffect;

        void Start()
        {
            //Transform pintu = Instantiate(pintuCollider) as Transform;
            //Physics.IgnoreCollision(pintu.GetComponent<Collider>(), GetComponent<Collider>());
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Player")
            {
                if (openTrigger)
                {
                    myDoor.Play(doorOpen, 0, 0.0f);
                    gameObject.SetActive(true);
                    Debug.Log(openTrigger);
                    openDoorSoundEffect.Play();
                }

                else if (closeTrigger)
                {
                    myDoor.Play(doorClose, 0, 0.0f);
                    gameObject.SetActive(false);
                    Debug.Log(closeTrigger);

                    Destroy(pintuCollider.gameObject);
                }
            }
        }
    }
}