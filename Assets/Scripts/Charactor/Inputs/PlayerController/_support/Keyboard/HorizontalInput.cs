using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{

    public class HorizontalInput : MovementController
    {
        public float keyY;

        public void playerHorizontalInput()
        {
            // Get player horizontal input from input manager.
            keyY = Input.GetAxisRaw("Horizontal");
        }
    }
}
