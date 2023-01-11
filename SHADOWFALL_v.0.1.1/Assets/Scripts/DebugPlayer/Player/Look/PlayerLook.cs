//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region PlayerLook : PlayerMovements
// Script description
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerLook : PlayerMovements
    {
        private float mouseX;
        private float mouseY;
        private float xRotation;
        private float yRotation;

        public void resetLooking(){
            _playerHead.rotation = Quaternion.Euler(0, 0, 0);
        }

        public void Look()
        {
            MouseX();
            MouseY();

            yRotation += mouseX;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            _playerBody.rotation = Quaternion.Euler(0, yRotation, 0);
            _playerHead.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        }

        private void MouseX()
        {
            mouseX = Input.GetAxisRaw("Mouse X") * mouseSensitivity * Time.deltaTime * 10;
        }
        private void MouseY()
        {
            mouseY = Input.GetAxisRaw("Mouse Y") * mouseSensitivity * Time.deltaTime * 10;
        }
    }
}
