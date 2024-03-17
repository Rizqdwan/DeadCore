using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeadCore
{
    public class doorTimerController : MonoBehaviour
    {
        [SerializeField] private Animator myDoor = null;

        [SerializeField] private bool openTrigger = false;

        [SerializeField] private bool closeTrigger = true;

        [SerializeField] private string doorOpen = "doorOpen";

        [SerializeField] private string doorClose = "doorClose";

        [SerializeField] public Transform pintuCollider;

        [SerializeField] private AudioSource openDoorSoundEffect;

        [SerializeField] private Timer countdownTimer; // Reference to the Timer component'

        [SerializeField] float counttime;

        [SerializeField] GameObject Timer;

        void Start()
        {
            // You can get the Timer component in various ways, e.g., by finding it in the scene
            countdownTimer = FindObjectOfType<Timer>();
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

                    // Start the countdown when the door opens
                    if (countdownTimer != null)
                    {
                        //TimerIn();
                        countdownTimer.StartCountdown(counttime); // Set the initial time as needed
                        Debug.Log("Jalan");
                    }
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
        //private void TimerIn()
        //{
        //    Timer.SetActive(true);
        //}
    }
}
