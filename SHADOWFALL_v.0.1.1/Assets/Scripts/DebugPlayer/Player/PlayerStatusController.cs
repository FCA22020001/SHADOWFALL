//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region PlayerStatusController : PlayerMovements
// This script can change player's status.
// Example:
//     isGround = true; // This means to player is on grounding now.
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerStatusController : PlayerMovements
    {
        private void PlayerGroundChecker()
        {
            // Here can check for player is ground or not ground.
            if (_playerUnderRay.underDistance <= 1.0f)
            {
                STATUS.isGrounded = true;
            }
            if (_playerUnderRay.underDistance > 1.0f)
            {
                STATUS.isGrounded = false;
            }
        }
    }
}
