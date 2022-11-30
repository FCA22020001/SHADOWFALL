using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerInput_mouse : MovementCore
    {
        public bool mouseInputEnabled;

        public float mouseX;
        public float mouseY;

        public void playerInputMouse()
        {
            mouseX = Input.GetAxisRaw("Mouse X") * _keyConfig.xSensitivity * Time.deltaTime;
            mouseY = Input.GetAxisRaw("Mouse Y") * _keyConfig.ySensitivity * Time.deltaTime;
        }
    }
}
