//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region PlayerWalk : PlayerMovements
// This is script for player walk.
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerWalk : PlayerMovements
    {
        private float keyY;
        private float keyX;

        // Void space
        public void Walk(){
            //
            //if (PLAYER.nowGrounded && (nowSpeed >= _playerBody.magnitude)){}
            // Walk movement is here.
            keyboardHorizontalInput();
            keyboardVerticalInput();

            // Calculate move force.
            Vector3 move = _playerBody.transform.right * keyY + _playerBody.transform.forward * keyX;

            // Apply move force.
            _playerBody.AddForce(move.normalized * walkSpeed, ForceMode.Force);

            //debug
            //Debug.Log("NowSpeed " + _playerBody.velocity.magnitude);
        }

        private void keyboardHorizontalInput(){
            keyY = Input.GetAxisRaw("Horizontal");
        }
        private void keyboardVerticalInput(){
            keyX = Input.GetAxisRaw("Vertical");
        }
    }
}
