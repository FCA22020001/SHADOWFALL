using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class Run : MovementController
    {
        public void playerRun()
        {
            // Get horizontal and vertical input.
            _playerKeyHorizontal.playerHorizontalInput();
            _playerKeyVertical.playerVerticalInput();

            // Calculate move force
            Vector3 move = transform.right * _playerKeyVertical.keyX + transform.forward * _playerKeyHorizontal.keyY;

            // Apply force.
            _playerBody.AddForce(move * _playerStatus.runSpeed, ForceMode.Force);
        }
    }
}
