using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class Jump : MovementController
    {
        public void playerJump()
        {
            // Apply force
            _playerBody.AddForce(Vector3.up * _playerStatus.jumpForce, ForceMode.Impulse);
        }
    }
}
