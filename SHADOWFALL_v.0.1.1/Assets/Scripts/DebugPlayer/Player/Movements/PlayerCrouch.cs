//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region PlayerCrouch : SUCCESSION
// Player movement
// Crouch:
//     If player input KeyDown(Crouch) change scale and position
//     scale = 0.7
//     position = _playerBody.transform.y - 0.45
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerCrouch : PlayerMovements
    {
        public void Crouch()
        {
            if (Input.GetKey(KeyCode.LeftControl))
            {
                _playerBody.transform.localScale = new Vector3(1.2f, 0.7f, 1.2f);
                _playerBody.transform.position = new Vector3(_playerBody.transform.position.x, _playerBody.transform.position.y - 0.1f, _playerBody.transform.position.z);
            }
            else if (Input.GetKeyUp(KeyCode.LeftControl))
            {
                _playerBody.transform.localScale = new Vector3(1.2f, 1.5f, 1.2f);
                _playerBody.transform.position = new Vector3(_playerBody.transform.position.x, _playerBody.transform.position.y + 0.1f, _playerBody.transform.position.z);
            }
        }
    }
}
