//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region PlayerLeftWallMovements : PlayerMovements
// Script description
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerLeftWallMovements : PlayerMovements
    {
        [SerializeField] private float keepLeftWallForce = 50f;
        public void LeftWallRun()
        {
            _playerBody.useGravity = false;

            _playerBody.transform.localEulerAngles = new Vector3(_playerBody.transform.localEulerAngles.x, -10f, _playerBody.transform.localEulerAngles.z);

            _playerBody.AddForce(-_playerBody.transform.right * keepLeftWallForce, ForceMode.Force);
        }
    }
}
