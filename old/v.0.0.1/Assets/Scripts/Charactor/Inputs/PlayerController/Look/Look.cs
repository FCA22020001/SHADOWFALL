using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class Look : MovementController
    {
        private float xRotation;
        private float yRotation;
        public void playerLook()
        {
                _playerMouseX.playerInputMouseX();
                _playerMouseY.playerInputMouseY();

                yRotation += _playerMouseX.mouseX;

                xRotation -= _playerMouseY.mouseY;
                xRotation = Mathf.Clamp(xRotation, -90f, 90f);

                _playerBody.rotation = Quaternion.Euler(0, yRotation, 0);
                _playerCamera.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        }
    }
}
