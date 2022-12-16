using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class Crouch : MovementController
    {
        public void playerStartCrouch()
        {
            // I can't change scale of player when player crouch.
            // And crouch is only change camera's hight.
            _playerCamera.transform.localPosition = new Vector3(0f, 0.2f, 0f);

            // We need body crouch.It is only move camera hight.
            // For example,
            // _playerBody.transform.localScale = _playerCrouchScale;
            // _playerBody.transform.localPosition(transform.position.x, transform.position.y - 0.5f, transform.position.z);
        }

        public void playerStopCrouch()
        {
            _playerCamera.transform.localPosition = new Vector3(0f, 0.7f, 0f);
            // _playerBody.transform.localScale = _playerCrouchScale;
            // _playerBody.transform.localPosition(transform.position.x, transform.position.y + 0.5f, transform.position.z);
        }
    }
}
