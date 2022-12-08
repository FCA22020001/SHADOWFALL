using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class KeyConfig : MonoBehaviour
    {
        // Mouse sensitivity
        public float xSensitivity = 5f;
        public float ySensitivity = 5f;

        // Input settings
        public bool sprintHoldSwitch;

        // Default key configuration
        // WASD is vertical and horizontal input.
        public KeyCode jump = KeyCode.Space;
        public KeyCode sprint = KeyCode.LeftShift;
        public KeyCode crouch = KeyCode.LeftControl;
        public KeyCode fire = KeyCode.Mouse0;
        public KeyCode scope = KeyCode.Mouse1;
    }
}
