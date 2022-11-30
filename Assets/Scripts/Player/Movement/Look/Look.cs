using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class Look : MovementCore
    {
        private float xRotation;
        private float yRotation;

        public void playerLook()
        {
            _mouseInput.playerInputMouse();

            yRotation += _mouseInput.mouseX;

            xRotation -= _mouseInput.mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            playerBody.rotation = Quaternion.Euler(0, yRotation, 0);
            playerCamera.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        }
    }
}
