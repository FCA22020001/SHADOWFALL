using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerStatus
    {
        // PlayerStatus
        public float walkMaxSpeed;
        public float runMaxSpeed;
        public float jumpForce;
        public float jumpStrength;
        public float wallrunMaxSpeed;
        public float wallrunUpForce;
        public bool canRun;
        
        public bool grounded;
        public bool readyJump;
        public bool jumping;
        public bool readyDoubleJump;
        public bool wallRunning;
        public bool rightWall;
        public bool leftWall;

        // Input enable status
        public bool keyboardInput;
        public bool mouseInput;
        public bool isRunning;

        // Running status
        public float sprintStatus;
    }
}
