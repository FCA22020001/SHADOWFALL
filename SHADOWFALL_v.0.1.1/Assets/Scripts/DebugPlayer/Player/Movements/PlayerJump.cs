//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region PlayerJump : PlayerMovements
// Script description
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerJump : PlayerMovements
    {
        [SerializeField] private float jumpForce; // Set 12.0f

        public void Jump()
        {
                _playerBody.AddForce(_playerBody.transform.up * jumpForce, ForceMode.Impulse);
            //Debug.Log("ApperForce : " + _playerBody.velocity.y);
        }
    }
}
