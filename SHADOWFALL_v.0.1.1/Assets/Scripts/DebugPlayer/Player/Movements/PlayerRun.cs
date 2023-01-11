//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region PlayerRun : PlayerMovements
// Script description
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerRun : PlayerMovements
    {
        private float keyY;
        private float keyX;

        // Void space
        public void Run(){
            //
            //if (PLAYER.nowGrounded && (nowSpeed >= _playerBody.magnitude)){}
            // Run movement is here.
            keyboardHorizontalInput();
            keyboardVerticalInput();

            // Calculate move force.
            Vector3 move = _playerBody.transform.right * keyY + _playerBody.transform.forward * keyX;

            // Apply move force.
            _playerBody.AddForce(move.normalized * runSpeed, ForceMode.Force);

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
