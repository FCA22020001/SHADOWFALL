using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class Walk : MovementCore
    {
        public void playerWalk()
        {
            if(_playerStatus.keyboardInput == true)
            {
                // Get player keyboard vertical and horizontal input.
                _playerKey.PlayerInputkey();

                // Apply and calculate the direction to move the player.
                Vector3 movementDirection = playerBody.transform.forward * _playerKey.keyX + playerBody.transform.right * _playerKey.keyY;

                // Player is not running (walking)
                if (_playerStatus.isRunning == false)
                {
                    playerBody.AddForce(movementDirection * _playerStatus.walkMaxSpeed, ForceMode.Force);
                }
                // Player is running (running)
                if (_playerStatus.isRunning == true)
                {
                    playerBody.AddForce(movementDirection * _playerStatus.runMaxSpeed, ForceMode.Force);
                }
            }
        }
    }
}
