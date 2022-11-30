using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class Jump : MovementCore
    {
        [SerializeField] private GroundCheck groundCheck;

        private void Reset()
        {
            groundCheck = GetComponentInChildren<GroundCheck>();
        }

        private void LateUpdate()
        {
            // Jump when the Jump button is pressed and we are on the ground.
            if (Input.GetKeyDown(_keyConfig.jumpInput) && (!groundCheck || groundCheck.isGrounded))
            {
                playerBody.AddForce(Vector3.up * 100 * _playerStatus.jumpStrength);
            }
        }
    }
}
