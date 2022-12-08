using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class MouseXInput : MovementController
    {
        public float mouseX;
        public void playerInputMouseX()
        {
            mouseX = Input.GetAxisRaw("Mouse X") * _playerKeyConfig.xSensitivity * Time.deltaTime;
        }
    }
}
