using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class MouseYInput : MovementController
    {
        public float mouseY;
        public void playerInputMouseY()
        {
            mouseY = Input.GetAxisRaw("Mouse Y") * _playerKeyConfig.ySensitivity * Time.deltaTime;
        }
    }
}
