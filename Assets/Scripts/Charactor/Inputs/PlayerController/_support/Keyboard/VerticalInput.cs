using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{

    public class VerticalInput : MovementController
    {
        public float keyX;

        public void playerVerticalInput()
        {
            // Get player vertical input from input manager.
            keyX = Input.GetAxisRaw("Vertical");
        }
    }
}
