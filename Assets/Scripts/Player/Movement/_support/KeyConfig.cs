using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class KeyConfig : MonoBehaviour
    {
        // Moving
        public KeyCode forwardInput = KeyCode.W;
        public KeyCode backwardInput = KeyCode.S;
        public KeyCode leftInput = KeyCode.A;
        public KeyCode rightInput = KeyCode.D;
        public KeyCode sprintInput = KeyCode.LeftShift;
        public KeyCode crouchInput = KeyCode.LeftControl;
        public KeyCode jumpInput = KeyCode.Space;

        // Attack
        public KeyCode fireInput = KeyCode.Mouse0;
        public KeyCode scopeInput = KeyCode.Mouse1;
        //public float zoomScopeInput = Input.mouseScrollDelta.y; // If use this, example) this.zoomScopeInput < 0f or this.zoomScopeInput > 0f
        public KeyCode punchInput = KeyCode.V;

        // Menu
        public KeyCode selectItem = KeyCode.Mouse0;
        public KeyCode useItem = KeyCode.Mouse1;
        public KeyCode tabMenuInput = KeyCode.Tab;
        public KeyCode escMenuInput = KeyCode.Escape;

        // Player input config
        public float xSensitivity;
        public float ySensitivity;
        public float sensMultiplier;
        public bool sprintHoldSwitch;
        public float shsCount;
    }
}
