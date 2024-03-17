using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace DeadCore
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI timerText;
        [SerializeField] float remainingTime;
        private bool countingDown = false;

        [SerializeField] GameObject gameOver;
        [SerializeField] AudioSource audioSource;


        void FixedUpdate()
        {
            if (countingDown && remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
                UpdateTimerDisplay();
            }
            else if (remainingTime <= 0)
            {
                remainingTime = 0;
                Time.timeScale = 0;
                GameOver();
                MuteAudio();
                Debug.Log("Time.timeScale: " + Time.timeScale);
            }

        }

        public void StartCountdown(float initialTime)
        {
            countingDown = true;
            remainingTime = initialTime;
            UpdateTimerDisplay();
        }

        private void MuteAudio()
        {
            if (audioSource != null)
            {
                audioSource.mute = true;
            }
        }

        private void UnmuteAudio()
        {
            if (audioSource != null)
            {
                audioSource.mute = false;
            }
        }

        private void UpdateTimerDisplay()
        {
            int minute = Mathf.FloorToInt(Mathf.Max(remainingTime, 0) / 60);
            int seconds = Mathf.FloorToInt(Mathf.Max(remainingTime, 0) % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minute, seconds);
        }

        private void GameOver()
        {
            Time.timeScale = 0;
            MuteAudio();
            gameOver.SetActive(true);
        }


        public void StopCountdown()
        {
            countingDown = false;
            MuteAudio();
        }

        public void StartCount()
        {
            countingDown = true;
            UnmuteAudio();
        }



    }
}