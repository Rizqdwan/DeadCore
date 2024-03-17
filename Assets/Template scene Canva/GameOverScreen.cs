using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DeadCore
{
    public class GameOverScreen : MonoBehaviour
    {
        public void RestartButton()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void ExitButton()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}


