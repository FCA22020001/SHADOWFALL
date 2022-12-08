using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerStatus
    {
        // Default raycast general position.
        public Transform playerHead;

        // Player movement core variables.
        public const float walkSpeed = 5f;
        public const float runSpeed = 8f;
        public float nowAllowSpeed;

        // Player input status.
        public bool keboardInputEnables;
        public bool mouseInputEnables;

        // Player default status.
        public bool isGrounded;

        // Player ready status.
        public bool canFire;
        public bool canMove;
        public bool canWalk;
        public bool canDash;
        public bool canJump;
        public bool canCrouch;
        public bool canSliding;
        public bool canDoubleJump;
        public bool canWallrun;
        public bool canWallJump;

        // Player doing status
        public bool walking;
        public bool running;
        public bool jumping;
        public bool crouching;
        public bool sliding;
        public bool wallrunning;
        public bool leftwall;
        public bool rightwall;
    }
}
