using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class Stay : PlayerStatusController
    {
        public void stayGround()
        {
            _playerStatus.isGrounded = true;
            _playerStatus.canJump = true;
        }

        #region Stay wall
        public void stayLeftWall()
        {
            _playerStatus.rightwall = false;
            _playerStatus.canWallJump = true;
            _playerStatus.wallrunning = true;
        }
        public void stayRightWall()
        {
            _playerStatus.leftwall = false;
            _playerStatus.canWallJump = true;
            _playerStatus.wallrunning = true;
        }
        #endregion
    }
}
