using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace DeadCore
{
    public class FinishLine : MonoBehaviour
    {
        [SerializeField] GameObject finishScene;
        [SerializeField] public Transform Collider;
        [SerializeField] public AudioSource audioSource;

        [SerializeField] private Timer countdownTimer;

        private bool hasFinished = false;

        void Start()
        {
            // You can get the Timer component in various ways, e.g., by finding it in the scene
            countdownTimer = FindObjectOfType<Timer>();
        }
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Player" && !hasFinished)
            {
                hasFinished = true;
                finish();
                StopTimer();
                Debug.Log("Berhasil");
            }
        }
        private void Update()
        {
            if (hasFinished)
            {
                PauseGame();
            }
        }

        private void PauseGame()
        {
            Time.timeScale = 0f;

            if (audioSource != null)
            {
                audioSource.mute = true;
            }
        }
        private void StopTimer()
        {
            // Stop the countdown in the Timer script
            if (countdownTimer != null)
            {
                countdownTimer.StopCountdown();
            }
        }
        private void finish()
        {
            finishScene.SetActive(true);
        }
    }
}
