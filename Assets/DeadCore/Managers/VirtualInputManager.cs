using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeadCore
{
    public class VirtualInputManager : Singleton<VirtualInputManager>
    {
        public bool MoveRight;
        public bool MoveLeft;
        public bool Jump;
        public bool Esc;
    }
}