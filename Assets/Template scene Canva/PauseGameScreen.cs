//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//namespace DeadCore
//{
//    public class PauseGameScreen : MonoBehaviour
//    {
//        public GameObject PausePanel;
//        private bool isPaused = false;

//        [SerializeField] private Timer countdownTimer;
//        [SerializeField] AudioSource audioSource;

//        private void Update()
//        {
//            if (Input.GetKeyDown(KeyCode.Escape))
//            {
//                isPaused = !isPaused;

//                if (isPaused)
//                {
//                    countdownTimer.PauseGame();
//                    MuteAudioGame();
//                }
//                else
//                {
//                    countdownTimer.ResumeGame();
//                    UnmuteAudioGame();
//                }

//                PausePanel.SetActive(isPaused);
//                Debug.Log("Escape pressed");
//            }
//        }

//        public void MainMenuButton()
//        {
//            SceneManager.LoadScene("MainMenu");
//        }

//        private void MuteAudioGame()
//        {
//            if (audioSource != null)
//            {
//                audioSource.mute = true;
//            }
//        }

//        private void UnmuteAudioGame()
//        {
//            if (audioSource != null)
//            {
//                audioSource.mute = false;
//            }
//        }
//    }
//}
