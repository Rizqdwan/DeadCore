using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeadCore
{
    public class ManualInput : MonoBehaviour
    {
        private CharacterControl characterControl;

        [SerializeField] private AudioSource runningSoundEffect;
        [SerializeField] private AudioSource jumpSoundEffect;

        private void Awake()
        {
            characterControl = this.gameObject.GetComponent<CharacterControl>();
        }

        void Update()
        {
            if (VirtualInputManager.Instance.MoveRight)
            {
                characterControl.MoveRight = true;
                runningSoundEffect.Play();
            }
            else
            {
                characterControl.MoveRight = false;
            }

            if (VirtualInputManager.Instance.MoveLeft)
            {
                characterControl.MoveLeft = true;
                runningSoundEffect.Play();
            }
            else
            {
                characterControl.MoveLeft = false;
            }

            if (VirtualInputManager.Instance.Jump)
            {
                characterControl.Jump = true;
                jumpSoundEffect.Play();
            }
            else
            {
                characterControl.Jump = false;
            }
            if (Input.GetKey(KeyCode.Escape))
            {
                VirtualInputManager.Instance.Esc = true;
            }
            else
            {
                VirtualInputManager.Instance.Esc = false;
            }
        }
    }
}