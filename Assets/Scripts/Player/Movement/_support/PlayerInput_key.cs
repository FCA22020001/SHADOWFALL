using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerInput_key : MovementCore
{
        public float keyX;
        public float keyY;

        public void PlayerInputkey()
        {
            // Get the Moving Inputs from InputManager.
            keyX = Input.GetAxisRaw("Vertical");
            keyY = Input.GetAxisRaw("Horizontal");
        }
    }
}
