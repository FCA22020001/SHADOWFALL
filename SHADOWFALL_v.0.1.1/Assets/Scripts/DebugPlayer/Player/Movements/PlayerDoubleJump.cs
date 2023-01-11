//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region PlayerDoubleJump : PlayerMovements
// Script description
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerDoubleJump : PlayerMovements
    {
        [SerializeField] private float doubleJumpForce; // Set 8.0f
        public void DoubleJump()
        {
                _playerBody.AddForce(_playerBody.transform.up * doubleJumpForce, ForceMode.Impulse);
        }
    }
}
