using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class DoubleJump : MovementController
    {
        public void playerDoubleJump()
        {
            // Apply force
            _playerBody.AddForce(Vector3.up * _playerStatus.jumpForce, ForceMode.Impulse);
        }
    }
}
