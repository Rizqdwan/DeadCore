using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DeadCore
{
    public class FinishGameScreen : MonoBehaviour
    {
        public void ExitButton()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

}

